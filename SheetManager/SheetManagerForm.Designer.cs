namespace InvAddIn
{
    partial class SheetManagerForm
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
            this.sheetListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.selectAllBtn = new System.Windows.Forms.Button();
            this.deselectAllBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.doneBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sheetListView
            // 
            this.sheetListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.sheetListView.Location = new System.Drawing.Point(12, 12);
            this.sheetListView.Name = "sheetListView";
            this.sheetListView.Size = new System.Drawing.Size(237, 400);
            this.sheetListView.TabIndex = 1;
            this.sheetListView.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Sheet Name";
            // 
            // selectAllBtn
            // 
            this.selectAllBtn.Location = new System.Drawing.Point(12, 418);
            this.selectAllBtn.Name = "selectAllBtn";
            this.selectAllBtn.Size = new System.Drawing.Size(75, 23);
            this.selectAllBtn.TabIndex = 2;
            this.selectAllBtn.Text = "Select All";
            this.selectAllBtn.UseVisualStyleBackColor = true;
            this.selectAllBtn.Click += new System.EventHandler(this.selectAllBtn_Click);
            // 
            // deselectAllBtn
            // 
            this.deselectAllBtn.Location = new System.Drawing.Point(94, 418);
            this.deselectAllBtn.Name = "deselectAllBtn";
            this.deselectAllBtn.Size = new System.Drawing.Size(75, 23);
            this.deselectAllBtn.TabIndex = 3;
            this.deselectAllBtn.Text = "Deselect All";
            this.deselectAllBtn.UseVisualStyleBackColor = true;
            this.deselectAllBtn.Click += new System.EventHandler(this.deselectAllBtn_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 447);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Activate";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(93, 447);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Deactivate";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // doneBtn
            // 
            this.doneBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.doneBtn.Location = new System.Drawing.Point(174, 447);
            this.doneBtn.Name = "doneBtn";
            this.doneBtn.Size = new System.Drawing.Size(75, 23);
            this.doneBtn.TabIndex = 6;
            this.doneBtn.Text = "Done";
            this.doneBtn.UseVisualStyleBackColor = true;
            // 
            // SheetManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.doneBtn;
            this.ClientSize = new System.Drawing.Size(261, 482);
            this.Controls.Add(this.doneBtn);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.deselectAllBtn);
            this.Controls.Add(this.selectAllBtn);
            this.Controls.Add(this.sheetListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SheetManagerForm";
            this.Text = "Sheet Manager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView sheetListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button selectAllBtn;
        private System.Windows.Forms.Button deselectAllBtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button doneBtn;
    }
}