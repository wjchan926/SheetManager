﻿namespace InvAddIn
{
    partial class PrinterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ecnRadBtn = new System.Windows.Forms.RadioButton();
            this.erRadBtn = new System.Windows.Forms.RadioButton();
            this.vendorRadBtn = new System.Windows.Forms.RadioButton();
            this.mfgRelRadBtn = new System.Windows.Forms.RadioButton();
            this.designRadBtn = new System.Windows.Forms.RadioButton();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.vendorGroupBox = new System.Windows.Forms.GroupBox();
            this.startPagetb = new System.Windows.Forms.TextBox();
            this.endPagetb = new System.Windows.Forms.TextBox();
            this.vendorTypetb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.vendorGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.vendorRadBtn);
            this.groupBox1.Controls.Add(this.vendorGroupBox);
            this.groupBox1.Controls.Add(this.ecnRadBtn);
            this.groupBox1.Controls.Add(this.erRadBtn);
            this.groupBox1.Controls.Add(this.mfgRelRadBtn);
            this.groupBox1.Controls.Add(this.designRadBtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 238);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Printing Option:";
            // 
            // ecnRadBtn
            // 
            this.ecnRadBtn.AutoSize = true;
            this.ecnRadBtn.Location = new System.Drawing.Point(13, 88);
            this.ecnRadBtn.Name = "ecnRadBtn";
            this.ecnRadBtn.Size = new System.Drawing.Size(181, 17);
            this.ecnRadBtn.TabIndex = 4;
            this.ecnRadBtn.TabStop = true;
            this.ecnRadBtn.Text = "Engineering Change Notice Form";
            this.ecnRadBtn.UseVisualStyleBackColor = true;
            // 
            // erRadBtn
            // 
            this.erRadBtn.AutoSize = true;
            this.erRadBtn.Location = new System.Drawing.Point(13, 65);
            this.erRadBtn.Name = "erRadBtn";
            this.erRadBtn.Size = new System.Drawing.Size(149, 17);
            this.erRadBtn.TabIndex = 3;
            this.erRadBtn.TabStop = true;
            this.erRadBtn.Text = "Engineering Release Form";
            this.erRadBtn.UseVisualStyleBackColor = true;
            // 
            // vendorRadBtn
            // 
            this.vendorRadBtn.AutoSize = true;
            this.vendorRadBtn.Location = new System.Drawing.Point(13, 111);
            this.vendorRadBtn.Name = "vendorRadBtn";
            this.vendorRadBtn.Size = new System.Drawing.Size(83, 17);
            this.vendorRadBtn.TabIndex = 2;
            this.vendorRadBtn.TabStop = true;
            this.vendorRadBtn.Text = "Vendor Print";
            this.vendorRadBtn.UseVisualStyleBackColor = true;
            this.vendorRadBtn.CheckedChanged += new System.EventHandler(this.vendorRadBtn_CheckedChanged);
            // 
            // mfgRelRadBtn
            // 
            this.mfgRelRadBtn.AutoSize = true;
            this.mfgRelRadBtn.Location = new System.Drawing.Point(13, 42);
            this.mfgRelRadBtn.Name = "mfgRelRadBtn";
            this.mfgRelRadBtn.Size = new System.Drawing.Size(135, 17);
            this.mfgRelRadBtn.TabIndex = 1;
            this.mfgRelRadBtn.TabStop = true;
            this.mfgRelRadBtn.Text = "Manufacturing Release";
            this.mfgRelRadBtn.UseVisualStyleBackColor = true;
            // 
            // designRadBtn
            // 
            this.designRadBtn.AutoSize = true;
            this.designRadBtn.Checked = true;
            this.designRadBtn.Location = new System.Drawing.Point(13, 19);
            this.designRadBtn.Name = "designRadBtn";
            this.designRadBtn.Size = new System.Drawing.Size(145, 17);
            this.designRadBtn.TabIndex = 0;
            this.designRadBtn.TabStop = true;
            this.designRadBtn.Text = "Design Approval Drawing";
            this.designRadBtn.UseVisualStyleBackColor = true;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(63, 256);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 1;
            this.saveBtn.Text = "Save PDF";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(144, 256);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 2;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // vendorGroupBox
            // 
            this.vendorGroupBox.Controls.Add(this.label3);
            this.vendorGroupBox.Controls.Add(this.label2);
            this.vendorGroupBox.Controls.Add(this.label1);
            this.vendorGroupBox.Controls.Add(this.vendorTypetb);
            this.vendorGroupBox.Controls.Add(this.endPagetb);
            this.vendorGroupBox.Controls.Add(this.startPagetb);
            this.vendorGroupBox.Enabled = false;
            this.vendorGroupBox.Location = new System.Drawing.Point(13, 123);
            this.vendorGroupBox.Name = "vendorGroupBox";
            this.vendorGroupBox.Size = new System.Drawing.Size(181, 108);
            this.vendorGroupBox.TabIndex = 5;
            this.vendorGroupBox.TabStop = false;
            // 
            // startPagetb
            // 
            this.startPagetb.Enabled = false;
            this.startPagetb.Location = new System.Drawing.Point(6, 28);
            this.startPagetb.Name = "startPagetb";
            this.startPagetb.Size = new System.Drawing.Size(60, 20);
            this.startPagetb.TabIndex = 0;
            // 
            // endPagetb
            // 
            this.endPagetb.Enabled = false;
            this.endPagetb.Location = new System.Drawing.Point(94, 28);
            this.endPagetb.Name = "endPagetb";
            this.endPagetb.Size = new System.Drawing.Size(60, 20);
            this.endPagetb.TabIndex = 1;
            // 
            // vendorTypetb
            // 
            this.vendorTypetb.Enabled = false;
            this.vendorTypetb.Location = new System.Drawing.Point(6, 78);
            this.vendorTypetb.Name = "vendorTypetb";
            this.vendorTypetb.Size = new System.Drawing.Size(169, 20);
            this.vendorTypetb.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pages:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "to";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vendor Type:";
            // 
            // PrinterForm
            // 
            this.AcceptButton = this.saveBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelBtn;
            this.ClientSize = new System.Drawing.Size(230, 290);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PrinterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Print Manager";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.vendorGroupBox.ResumeLayout(false);
            this.vendorGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton ecnRadBtn;
        private System.Windows.Forms.RadioButton erRadBtn;
        private System.Windows.Forms.RadioButton vendorRadBtn;
        private System.Windows.Forms.RadioButton mfgRelRadBtn;
        private System.Windows.Forms.RadioButton designRadBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.GroupBox vendorGroupBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox vendorTypetb;
        private System.Windows.Forms.TextBox endPagetb;
        private System.Windows.Forms.TextBox startPagetb;
    }
}