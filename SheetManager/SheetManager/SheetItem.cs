using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventor;

namespace InvAddIn
{
    class SheetItem
    {
        private Sheet sheet;
        private string name;

        public SheetItem(Sheet s)
        {
            sheet = s;
            name = s.Name;
        }

        public SheetItem(SheetItem sheetItem)
        {
            sheet = sheetItem.getSheet();
            name = sheetItem.getName();
        }

        public Sheet getSheet()
        {
            return sheet;
        }

        public string getName()
        {
            return name;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
