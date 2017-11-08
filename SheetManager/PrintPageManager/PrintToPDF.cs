using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventor;
using System.Runtime.InteropServices;


namespace InvAddIn
{
    class PrintToPDF
    {
        private string printType;
        private string printLocation;
        private int startSheet;
        private int endSheet;
        private string description;

        private static Dictionary<string, string> pdfType = new Dictionary<string, string>();

        static PrintToPDF(){
            pdfType.Add("Design", "\\\\MSW-FP1\\Shared\\Cad\\Design Approval Dwgs\\");
            pdfType.Add("Release", "\\\\MSW-FP1\\Factory\\RELEASED DESIGNS\\");
            pdfType.Add("ER", "\\\\MSW-FP1\\Shared\\ISO9001_QMS\\ENGINEERING RELEASES\\");
            pdfType.Add("ECN", "\\\\MSW-FP1\\Shared\\ISO9001_QMS\\ENGINEERING CHANGE NOTICES\\");
            pdfType.Add("Tooling", "\\\\MSW-FP1\\Shared\\Design Approval Dwgs\\Tooling Drawings\\");
            pdfType.Add("Vendor", "\\\\MSW-FP1\\Shared\\Design Approval Dwgs\\VENDOR DESIGN APPROVALS\\");
        }
                
        // Constructor
        public PrintToPDF(string s)
        {
            printType = s;
            printLocation = pdfType[printType];
        }

        // Tooling Constructor
        public PrintToPDF(string s, string desc)
        {            
            printType = s;
            description = desc;
            printLocation = pdfType[printType];
        }

        // Vendor Constructor
        public PrintToPDF(string s, int start, int end, string desc)
        {
            printType = s;
            startSheet = start;
            endSheet = end;
            printLocation = pdfType[printType];
        }
        
        public void print()
        {
            Application inventorApp = (Application)Marshal.GetActiveObject("Inventor.Application");
            DrawingDocument drawing = (DrawingDocument)inventorApp.ActiveDocument;

            // This is the ID for the PDF addin, Casted to TranslatorAddIn
            TranslatorAddIn oPDFAddin = (Inventor.TranslatorAddIn)inventorApp.ApplicationAddIns.ItemById["{0AC6FD96-2F4D-42CE-8BE0-8AEA580399E4}"];

            // Get the required document properties
            string displayName = drawing.DisplayName;
            Property rev = drawing.PropertySets["Inventor Summary Information"]["Revision Number"];

            Property erecn = drawing.PropertySets["Inventor User Defined Properties"]["ER/ECN#"];            

            TranslationContext context = inventorApp.TransientObjects.CreateTranslationContext();
            context.Type = IOMechanismEnum.kFileBrowseIOMechanism;

            NameValueMap options = inventorApp.TransientObjects.CreateNameValueMap();

            DataMedium dataMedium = inventorApp.TransientObjects.CreateDataMedium();

            // Set PDF Print Options
            if (oPDFAddin.HasSaveCopyAsOptions[dataMedium, context, options])
            {
                options.Value["All_Color_AS_Black"] = 0;
                options.Value["Remove_Line_Weights"] = 1;
                options.Value["Vector_Resolution"] = 400;

                // Need Print Range for Vendor Prints
                if (printType != "Vendor")
                {
                    options.Value["Sheet Range"] = Inventor.PrintRangeEnum.kPrintAllSheets;
                }
                else
                {
                    options.Value["Custom_Begin_Sheet"] = startSheet;
                    options.Value["Custom_End_Sheet"] = endSheet;
                    options.Value["Sheet Range"] = Inventor.PrintRangeEnum.kPrintSheetRange;
                }

            }

            // Get Customer Name
            StringBuilder customerName = new StringBuilder(drawing.FullFileName.Trim());
            customerName.Remove(0, 18);

            int hyphenIndex = customerName.ToString().IndexOf('-');
            customerName.Remove(hyphenIndex, customerName.Length - hyphenIndex);     

            // Make the filename
            switch (printType)
            {
                case "Design":
                    dataMedium.FileName = printLocation + customerName.ToString().Trim() + "-" + displayName + "_REV " + rev.ToString() + ".pdf";
                    break;
                case "Release":
                    dataMedium.FileName = printLocation + displayName + ".pdf";
                    break;
                case "ER":
                case "ECN":
                    dataMedium.FileName = printLocation + displayName + "-" + erecn.ToString() + ".pdf";
                    break;
                case "Tooling":
                    dataMedium.FileName = printLocation + displayName + "_REV " + rev.ToString() "-" + description + ".pdf";
                    break;
                case "Vendor":
                    dataMedium.FileName = printLocation + displayName + "_REV " + rev.ToString() + "-" + description + ".pdf";
                    break;
            }

            try
            {
                oPDFAddin.SaveCopyAs(drawing, context, options, dataMedium);
            }
            finally
            {
                try
                {
                    System.Diagnostics.Process.Start(@printLocation);
                }
                catch (System.ComponentModel.Win32Exception win32Exception)
                {
                    //The system cannot find the file specified...
                    Console.WriteLine(win32Exception.Message);
                }
            }
        }
    }
}
