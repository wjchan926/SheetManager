using System;
using System.Runtime.InteropServices;
using Inventor;
using Microsoft.Win32;
using SheetManager;
using System.Windows.Forms;
using InvAddIn;
using System.Drawing;

namespace SheetManager
{
    /// <summary>
    /// This is the primary AddIn Server class that implements the ApplicationAddInServer interface
    /// that all Inventor AddIns are required to implement. The communication between Inventor and
    /// the AddIn is via the methods on this interface.
    /// </summary>
    [GuidAttribute("51d93f21-9159-40bd-82b0-c80d2ddfdb02")]
    public class StandardAddInServer : Inventor.ApplicationAddInServer
    {

        // Inventor application object.
        private Inventor.Application m_inventorApplication;
        private ButtonDefinition m_SheetManagerButton;
        private ButtonDefinition m_PrintManagerButton;
        private static string addInGUID = "51d93f21-9159-40bd-82b0-c80d2ddfdb02";

        public StandardAddInServer()
        {
        }
        
        #region ApplicationAddInServer Members

        public void Activate(Inventor.ApplicationAddInSite addInSiteObject, bool firstTime)
        {
            // This method is called by Inventor when it loads the addin.
            // The AddInSiteObject provides access to the Inventor Application object.
            // The FirstTime flag indicates if the addin is loaded for the first time.

            // Initialize AddIn members.
            m_inventorApplication = addInSiteObject.Application;

            // TODO: Add ApplicationAddInServer.Activate implementation.
            // e.g. event initialization, command creation etc.
            

            ControlDefinitions controlDefs = m_inventorApplication.CommandManager.ControlDefinitions;

            // Icons  
            //   System.Diagnostics.Debug.WriteLine(System.IO.Directory.GetCurrentDirectory());

            //string originalDir = System.IO.Directory.GetCurrentDirectory();
            //string dir = "%APPDATA%\\Autodesk\\ApplicationPlugins\\AssemblyToParts\\";
            //System.Diagnostics.Debug.WriteLine(System.IO.Directory.GetCurrentDirectory());
            //System.IO.Directory.SetCurrentDirectory(dir);
            //MessageBox.Show(System.IO.Directory.GetCurrentDirectory());

            string appData = System.Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData);

            Icon smallPushSM = new Icon(appData + @"\Autodesk\ApplicationPlugins\SheetManager\sheet manager.ico");
            Icon largePushSM = new Icon(appData + @"\Autodesk\ApplicationPlugins\SheetManager\sheet manager.ico");

            Icon smallPushPM = new Icon(appData + @"\Autodesk\ApplicationPlugins\SheetManager\print.ico");
            Icon largePushPM = new Icon(appData + @"\Autodesk\ApplicationPlugins\SheetManager\print.ico");

            //    System.IO.Directory.SetCurrentDirectory(originalDir);

            stdole.IPictureDisp smallPushIconSM = PictureDispConverter.ToIPictureDisp(smallPushSM);
            stdole.IPictureDisp largePushIconSM = PictureDispConverter.ToIPictureDisp(largePushSM);

            stdole.IPictureDisp smallPushIconPM = PictureDispConverter.ToIPictureDisp(smallPushPM);
            stdole.IPictureDisp largePushIconPM = PictureDispConverter.ToIPictureDisp(largePushPM);
            // End Icon code

            m_SheetManagerButton = controlDefs.AddButtonDefinition("Sheet\nManager", "SheetManager", CommandTypesEnum.kQueryOnlyCmdType, addInGUID, "Opens the Sheet Manager for the active drawing.", "Sheet Manager", smallPushIconSM, largePushIconSM);
            m_PrintManagerButton = controlDefs.AddButtonDefinition("Print\nManager", "PrintManager", CommandTypesEnum.kFileOperationsCmdType, addInGUID, "Opens the Print Manager for the active drawing.", "Print Manager", smallPushIconPM, largePushIconPM);

            if (firstTime)
            {

                try
                {
                    if (m_inventorApplication.UserInterfaceManager.InterfaceStyle == InterfaceStyleEnum.kRibbonInterface)
                    {
                        Ribbon ribbon = m_inventorApplication.UserInterfaceManager.Ribbons["Drawing"];
                        RibbonTab tab = ribbon.RibbonTabs["id_TabPlaceViews"];

                        try
                        {
                            // For ribbon interface
                            // This is a new panel that can be made
                            RibbonPanel panel = tab.RibbonPanels.Add("Drawing Manager", "Autodesk:DrawingManager:Panel1", addInGUID, "",false);
                            CommandControl control1 = panel.CommandControls.AddButton(m_SheetManagerButton, true, true, "", false);
                            CommandControl control2 = panel.CommandControls.AddButton(m_PrintManagerButton, true, true, "", false);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                    else
                    {
                        // For classic interface, possibly incorrect code
                        CommandBar oCommandBar = m_inventorApplication.UserInterfaceManager.CommandBars["DLxDrawingViewsPanelCmdBar"];
                        oCommandBar.Controls.AddButton(m_SheetManagerButton, 0);
                        oCommandBar.Controls.AddButton(m_PrintManagerButton, 0);
                    }
                }
                catch
                {
                    // For classic interface, possibly incorrect code
                    CommandBar oCommandBar = m_inventorApplication.UserInterfaceManager.CommandBars["DLxDrawingViewsPanelCmdBar"];
                    oCommandBar.Controls.AddButton(m_SheetManagerButton, 0);
                    oCommandBar.Controls.AddButton(m_PrintManagerButton, 0);
                }             
            }

            m_SheetManagerButton.OnExecute += new ButtonDefinitionSink_OnExecuteEventHandler(m_SheetManagerButton_OnExecute);
            m_PrintManagerButton.OnExecute += new ButtonDefinitionSink_OnExecuteEventHandler(m_PrintManagerButton_OnExecute);
        }

        public void Deactivate()
        {
            // This method is called by Inventor when the AddIn is unloaded.
            // The AddIn will be unloaded either manually by the user or
            // when the Inventor session is terminated

            // TODO: Add ApplicationAddInServer.Deactivate implementation

            // Release objects.
            Marshal.ReleaseComObject(m_inventorApplication);
            m_inventorApplication = null;

            Marshal.ReleaseComObject(m_SheetManagerButton);
            m_SheetManagerButton = null;

            Marshal.ReleaseComObject(m_PrintManagerButton);
            m_PrintManagerButton = null;

            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        public void ExecuteCommand(int commandID)
        {
            // Note:this method is now obsolete, you should use the 
            // ControlDefinition functionality for implementing commands.
        }

        public object Automation
        {
            // This property is provided to allow the AddIn to expose an API 
            // of its own to other programs. Typically, this  would be done by
            // implementing the AddIn's API interface in a class and returning 
            // that class object through this property.

            get
            {
                // TODO: Add ApplicationAddInServer.Automation getter implementation
                return null;
            }
        }

        public void m_SheetManagerButton_OnExecute(NameValueMap Context)
        {            
            SheetManagerForm sheetManagerForm = new SheetManagerForm(m_inventorApplication);
            sheetManagerForm.ShowDialog();
        }

        public void m_PrintManagerButton_OnExecute(NameValueMap Context)
        {
            PrinterForm printerForm = new PrinterForm(m_inventorApplication);
            printerForm.ShowDialog();                 
        }

        #endregion

    }

    public sealed class PictureDispConverter
    // This seciton creates the icons for the add-ins
    {
        [DllImport("OleAut32.dll", EntryPoint = "OleCreatePictureIndirect", ExactSpelling = true, PreserveSig = false)]
        private static extern stdole.IPictureDisp OleCreatePictureIndirect([MarshalAs(UnmanagedType.AsAny)]
            object picdesc, ref Guid iid, [MarshalAs(UnmanagedType.Bool)]
            bool fOwn);


        static Guid iPictureDispGuid = typeof(stdole.IPictureDisp).GUID;

        private sealed class PICTDESC
        {
            private PICTDESC()
            {
            }


            //Picture Types

            public const short PICTYPE_UNINITIALIZED = -1;
            public const short PICTYPE_NONE = 0;
            public const short PICTYPE_BITMAP = 1;
            public const short PICTYPE_METAFILE = 2;
            public const short PICTYPE_ICON = 3;

            public const short PICTYPE_ENHMETAFILE = 4;

            [StructLayout(LayoutKind.Sequential)]
            public class Icon
            {
                internal int cbSizeOfStruct = Marshal.SizeOf(typeof(PICTDESC.Icon));
                internal int picType = PICTDESC.PICTYPE_ICON;
                internal IntPtr hicon = IntPtr.Zero;
                internal int unused1;

                internal int unused2;

                internal Icon(System.Drawing.Icon icon)
                {
                    this.hicon = icon.ToBitmap().GetHicon();
                }
            }


            [StructLayout(LayoutKind.Sequential)]
            public class Bitmap
            {
                internal int cbSizeOfStruct = Marshal.SizeOf(typeof(PICTDESC.Bitmap));
                internal int picType = PICTDESC.PICTYPE_BITMAP;
                internal IntPtr hbitmap = IntPtr.Zero;
                internal IntPtr hpal = IntPtr.Zero;

                internal int unused;

                internal Bitmap(System.Drawing.Bitmap bitmap)
                {
                    this.hbitmap = bitmap.GetHbitmap();
                }
            }
        }


        public static stdole.IPictureDisp ToIPictureDisp(System.Drawing.Icon icon)
        {
            PICTDESC.Icon pictIcon = new PICTDESC.Icon(icon);
            return OleCreatePictureIndirect(pictIcon, ref iPictureDispGuid, true);
        }


        public static stdole.IPictureDisp ToIPictureDisp(System.Drawing.Bitmap bmp)
        {
            PICTDESC.Bitmap pictBmp = new PICTDESC.Bitmap(bmp);
            return OleCreatePictureIndirect(pictBmp, ref iPictureDispGuid, true);
        }
    }
}
