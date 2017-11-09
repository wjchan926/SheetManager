using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventor;

namespace InvAddIn
{
    public partial class SheetManagerForm : Form
    {

        private SheetList sheetList;

        public SheetManagerForm()
        {
            InitializeComponent();
            sheetList = new SheetList();

            // Add List of Pages to Sheet View
            foreach(SheetItem sheetItem in sheetList.getSheetList())
            {

                ListViewItem item = new ListViewItem();
                item.Text = sheetItem.getName();
                item.Tag = sheetItem;

                if (!item.Text.Equals("ER") && !item.Text.Equals("ECN"))
                {
                    sheetListView.Items.Add(item);
                }
            }
            
        }

        private void selectAllBtn_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem listViewItem in sheetListView.Items)
            {
                listViewItem.Checked = true;
            }
        }

        private void deselectAllBtn_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem listViewItem in sheetListView.Items)
            {
                listViewItem.Checked = false;
            }
        }

        private void activateBtn_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem listViewItem in sheetListView.CheckedItems)
            {               
                ((SheetItem)listViewItem.Tag).getSheet().ExcludeFromPrinting = false;
                ((SheetItem)listViewItem.Tag).getSheet().ExcludeFromCount = false;
            }
        }

        private void deactivateBtn_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem listViewItem in sheetListView.CheckedItems)
            {
                ((SheetItem)listViewItem.Tag).getSheet().ExcludeFromPrinting = true;
                ((SheetItem)listViewItem.Tag).getSheet().ExcludeFromCount = true;
            }
        }

        private void doneBtn_Click(object sender, EventArgs e)
        {          
            Close();
        }

        private void sheetListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
