using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventor;
using System.Runtime.InteropServices;
using System.Collections;

namespace InvAddIn
{
    // Class that will hold all the sheets in the drawing
    class SheetList
    {
        private Inventor.Application inventorApp;
        private DrawingDocument drawing;
        private ArrayList sheetList = new ArrayList();
  
        // Default Constructor
        public SheetList()
        {
            importSheets();
        }

        // Gets the List of sheets
        public ArrayList getSheetList()
        {
            return sheetList;
        }

        // Imports all the sheets from the current Inventor Drawing
        private void importSheets()
        {
            try
            {
                // Attempt to get a reference to a running instance of Inventor.
                inventorApp = (Inventor.Application)Marshal.GetActiveObject("Inventor.Application");

                drawing = (DrawingDocument)inventorApp.ActiveDocument;

                // Add each sheet to the list
                foreach (Sheet s in drawing.Sheets)
                {
                    SheetItem sheetItem = new SheetItem(s);
                    sheetList.Add(sheetItem);
                }
            }
            catch
            {
                return;
            }          
        }   
    }
}
