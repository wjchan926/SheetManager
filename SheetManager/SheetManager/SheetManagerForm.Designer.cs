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
            this.selectAllBtn = new System.Windows.Forms.Button();
            this.deselectAllBtn = new System.Windows.Forms.Button();
            this.activateBtn = new System.Windows.Forms.Button();
            this.deactivateBtn = new System.Windows.Forms.Button();
            this.doneBtn = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sheetListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
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
            // activateBtn
            // 
            this.activateBtn.Location = new System.Drawing.Point(12, 447);
            this.activateBtn.Name = "activateBtn";
            this.activateBtn.Size = new System.Drawing.Size(75, 23);
            this.activateBtn.TabIndex = 4;
            this.activateBtn.Text = "Activate";
            this.activateBtn.UseVisualStyleBackColor = true;
            this.activateBtn.Click += new System.EventHandler(this.activateBtn_Click);
            // 
            // deactivateBtn
            // 
            this.deactivateBtn.Location = new System.Drawing.Point(93, 447);
            this.deactivateBtn.Name = "deactivateBtn";
            this.deactivateBtn.Size = new System.Drawing.Size(75, 23);
            this.deactivateBtn.TabIndex = 5;
            this.deactivateBtn.Text = "Deactivate";
            this.deactivateBtn.UseVisualStyleBackColor = true;
            this.deactivateBtn.Click += new System.EventHandler(this.deactivateBtn_Click);
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
            this.doneBtn.Click += new System.EventHandler(this.doneBtn_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Sheet Name";
            this.columnHeader1.Width = 236;
            // 
            // sheetListView
            // 
            this.sheetListView.CheckBoxes = true;
            this.sheetListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.sheetListView.Location = new System.Drawing.Point(12, 12);
            this.sheetListView.Name = "sheetListView";
            this.sheetListView.Size = new System.Drawing.Size(237, 400);
            this.sheetListView.TabIndex = 1;
            this.sheetListView.UseCompatibleStateImageBehavior = false;
            this.sheetListView.View = System.Windows.Forms.View.Details;
            this.sheetListView.SelectedIndexChanged += new System.EventHandler(this.sheetListView_SelectedIndexChanged);
            // 
            // SheetManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.doneBtn;
            this.ClientSize = new System.Drawing.Size(261, 482);
            this.Controls.Add(this.doneBtn);
            this.Controls.Add(this.deactivateBtn);
            this.Controls.Add(this.activateBtn);
            this.Controls.Add(this.deselectAllBtn);
            this.Controls.Add(this.selectAllBtn);
            this.Controls.Add(this.sheetListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SheetManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sheet Manager";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button selectAllBtn;
        private System.Windows.Forms.Button deselectAllBtn;
        private System.Windows.Forms.Button activateBtn;
        private System.Windows.Forms.Button deactivateBtn;
        private System.Windows.Forms.Button doneBtn;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView sheetListView;
    }
}