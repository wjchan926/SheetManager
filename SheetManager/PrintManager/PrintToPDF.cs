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
        private String printType;
        private String printLocation;

        // Constructor
        public PrintToPDF(String s)
        {
            printType = s;
            setPrintLocation();
        }

        private void setPrintLocation()
        {     
            switch (printType)
            {
                case "Design Approval":
                    printLocation = "\\\\MSW-FP1\\Shared\\Design Approval Dwgs\\";
                    break;
                case "Release":
                    printLocation = "\\\\MSW-FP1\\Factory\\RELEASED DESIGNS\\";
                    break;
                case "ER":
                    printLocation = "\\\\MSW-FP1\\Shared\\ISO9001_QMS\\ENGINEERING RELEASES\\";
                    break;
                case "ECN":
                    printLocation = "\\\\MSW-FP1\\Shared\\ISO9001_QMS\\ENGINEERING CHANGE NOTICES\\";
                    break;
                case "Vendor":
                    printLocation = "\\\\MSW-FP1\\Shared\\Design Approval Dwgs\\VENDOR DESIGN APPROVALS\\";
                    break;
            }
        }

        public void print()
        {
            Application inventorApp = (Application)Marshal.GetActiveObject("Inventor.Application");
            DrawingDocument drawing = (DrawingDocument)inventorApp.ActiveDocument;

            // This is the ID for the PDF addin
            ApplicationAddIn oPDFAddin = inventorApp.ApplicationAddIns.ItemById["{0AC6FD96-2F4D-42CE-8BE0-8AEA580399E4}"];


            
            String displayName = drawing.DisplayName;
            Property rev = drawing.PropertySets["Inventor Summary Information"]["Revision Number"];
            
            if(printType == "ER" || printType == "ECN")
            {
                Property erecn = drawing.PropertySets["Inventor User Defined Properties"]["ER/ECN#"];
            }

            
        }
    }
}
