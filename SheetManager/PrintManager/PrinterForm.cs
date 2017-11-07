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
    public partial class PrinterForm : Form
    {
        private String printType;

        public PrinterForm()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void vendorRadBtn_CheckedChanged(object sender, EventArgs e)
        {
            vendorGroupBox.Enabled = vendorRadBtn.Checked;
            startPagetb.Enabled = vendorRadBtn.Checked;
            endPagetb.Enabled = vendorRadBtn.Checked;
            vendorTypetb.Enabled = vendorRadBtn.Checked;
            

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            PrintToPDF printToPDF = new PrintToPDF(printType);
            printToPDF.print();
            Close();
        }
    }
}
