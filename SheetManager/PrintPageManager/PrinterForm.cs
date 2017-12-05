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
        private string printType;

        public PrinterForm()
        {
            InitializeComponent();
            printType = "Design";

            SheetList tempSheetList = new InvAddIn.SheetList();
            numSheetstb.Text = (tempSheetList.getSize()-2).ToString();
            Console.WriteLine(tempSheetList.getSize());
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

            printType = "Vendor";                   

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            PrintToPDF printToPDF;

            switch (printType)
            {
                case "Tooling":
                    printToPDF = new PrintToPDF(printType, toolTypetf.Text.Trim());
                    printToPDF.print();
                    break;
                case "Vendor":
                    printToPDF = new PrintToPDF(printType, Int32.Parse(startPagetb.Text.Trim()), Int32.Parse(endPagetb.Text.Trim()), vendorTypetb.Text.Trim());
                    printToPDF.print();
                    break;
                default:
                    printToPDF = new PrintToPDF(printType);
                    printToPDF.print();
                    break;                
            }
            printToPDF = null;
     
            Close();
        }

        private void toolingRadBtn_CheckedChanged(object sender, EventArgs e)
        {
            toolGroupBox.Enabled = toolingRadBtn.Checked;
            toolTypetf.Enabled = toolingRadBtn.Checked;

            printType = "Tooling";
        
        }
        
        private void designRadBtn_CheckedChanged(object sender, EventArgs e)
        {
            printType = "Design";
        }

        private void mfgRelRadBtn_CheckedChanged(object sender, EventArgs e)
        {
            printType = "Release";
        }

        private void erRadBtn_CheckedChanged(object sender, EventArgs e)
        {
            printType = "ER";
        }

        private void ecnRadBtn_CheckedChanged(object sender, EventArgs e)
        {
            printType = "ECN";
        }
       
    }
}
