using System;
using System.Runtime.InteropServices;
using Inventor;
using Microsoft.Win32;
using SheetManager;
using System.Windows.Forms;
using InvAddIn;


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
        private static String addInGUID = "51d93f21-9159-40bd-82b0-c80d2ddfdb02";

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

            m_SheetManagerButton = controlDefs.AddButtonDefinition("Sheet Manager", "SheetManager", CommandTypesEnum.kQueryOnlyCmdType, addInGUID, "Opens the Sheet Manager for the active drawing.", "Sheet Manager");

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
                            RibbonPanel panel = tab.RibbonPanels.Add("Sheet Manager", "Autodesk:SheetManager:Panel1", addInGUID, "", false);
                            CommandControl control1 = panel.CommandControls.AddButton(m_SheetManagerButton, true, true, "", false);
                        }
                        catch (Exception ex)
                        {

                        }
                    }
                    else
                    {
                        // For classic interface, possibly incorrect code
                        CommandBar oCommandBar = m_inventorApplication.UserInterfaceManager.CommandBars["DLxDrawingViewCmdBar"];
                        oCommandBar.Controls.AddButton(m_SheetManagerButton, 0);
                    }
                }
                catch
                {
                    // For classic interface, possibly incorrect code
                    CommandBar oCommandBar = m_inventorApplication.UserInterfaceManager.CommandBars["DLxDrawingViewCmdBar"];
                    oCommandBar.Controls.AddButton(m_SheetManagerButton, 0);
                }             
            }

            m_SheetManagerButton.OnExecute += new ButtonDefinitionSink_OnExecuteEventHandler(m_SheetManagerButton_OnExecute);
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
            SheetManagerForm smf = new SheetManagerForm();
            smf.Show();
        }

        #endregion

    }
}
