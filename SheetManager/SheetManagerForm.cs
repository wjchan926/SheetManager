using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            sheetListView.Items.Add(sheetList.ToString());
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
    }
}
