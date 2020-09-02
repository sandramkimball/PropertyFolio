namespace PropertyFolio.Forms
{
    partial class PropertiesForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PropertiesListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OwnerLabel = new System.Windows.Forms.Label();
            this.RenterLabel = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.HistoryLabel = new System.Windows.Forms.Label();
            this.PayHistoryLabel = new System.Windows.Forms.Label();
            this.HOALabel = new System.Windows.Forms.Label();
            this.NotesLabel = new System.Windows.Forms.Label();
            this.OwnerInput = new System.Windows.Forms.TextBox();
            this.RentersInput = new System.Windows.Forms.TextBox();
            this.TypeInput = new System.Windows.Forms.TextBox();
            this.AddressInput = new System.Windows.Forms.TextBox();
            this.HOAInput = new System.Windows.Forms.TextBox();
            this.NotesInput = new System.Windows.Forms.TextBox();
            this.WorkHistoryList = new System.Windows.Forms.ListBox();
            this.PayHistoryList = new System.Windows.Forms.ListBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PropertiesListBox
            // 
            this.PropertiesListBox.FormattingEnabled = true;
            this.PropertiesListBox.ItemHeight = 15;
            this.PropertiesListBox.Location = new System.Drawing.Point(53, 70);
            this.PropertiesListBox.Name = "PropertiesListBox";
            this.PropertiesListBox.Size = new System.Drawing.Size(199, 454);
            this.PropertiesListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Properties";
            // 
            // OwnerLabel
            // 
            this.OwnerLabel.AutoSize = true;
            this.OwnerLabel.Location = new System.Drawing.Point(498, 71);
            this.OwnerLabel.Name = "OwnerLabel";
            this.OwnerLabel.Size = new System.Drawing.Size(42, 15);
            this.OwnerLabel.TabIndex = 2;
            this.OwnerLabel.Text = "Owner";
            // 
            // RenterLabel
            // 
            this.RenterLabel.AutoSize = true;
            this.RenterLabel.Location = new System.Drawing.Point(498, 99);
            this.RenterLabel.Name = "RenterLabel";
            this.RenterLabel.Size = new System.Drawing.Size(46, 15);
            this.RenterLabel.TabIndex = 2;
            this.RenterLabel.Text = "Renters";
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Location = new System.Drawing.Point(509, 128);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(31, 15);
            this.TypeLabel.TabIndex = 2;
            this.TypeLabel.Text = "Type";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(495, 159);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(49, 15);
            this.AddressLabel.TabIndex = 2;
            this.AddressLabel.Text = "Address";
            // 
            // HistoryLabel
            // 
            this.HistoryLabel.AutoSize = true;
            this.HistoryLabel.Location = new System.Drawing.Point(324, 257);
            this.HistoryLabel.Name = "HistoryLabel";
            this.HistoryLabel.Size = new System.Drawing.Size(76, 15);
            this.HistoryLabel.TabIndex = 2;
            this.HistoryLabel.Text = "Work History";
            // 
            // PayHistoryLabel
            // 
            this.PayHistoryLabel.AutoSize = true;
            this.PayHistoryLabel.Location = new System.Drawing.Point(535, 255);
            this.PayHistoryLabel.Name = "PayHistoryLabel";
            this.PayHistoryLabel.Size = new System.Drawing.Size(95, 15);
            this.PayHistoryLabel.TabIndex = 2;
            this.PayHistoryLabel.Text = "Payment History";
            // 
            // HOALabel
            // 
            this.HOALabel.AutoSize = true;
            this.HOALabel.Location = new System.Drawing.Point(511, 189);
            this.HOALabel.Name = "HOALabel";
            this.HOALabel.Size = new System.Drawing.Size(33, 15);
            this.HOALabel.TabIndex = 2;
            this.HOALabel.Text = "HOA";
            // 
            // NotesLabel
            // 
            this.NotesLabel.AutoSize = true;
            this.NotesLabel.Location = new System.Drawing.Point(324, 402);
            this.NotesLabel.Name = "NotesLabel";
            this.NotesLabel.Size = new System.Drawing.Size(38, 15);
            this.NotesLabel.TabIndex = 2;
            this.NotesLabel.Text = "Notes";
            // 
            // OwnerInput
            // 
            this.OwnerInput.Location = new System.Drawing.Point(546, 68);
            this.OwnerInput.Name = "OwnerInput";
            this.OwnerInput.Size = new System.Drawing.Size(188, 23);
            this.OwnerInput.TabIndex = 3;
            // 
            // RentersInput
            // 
            this.RentersInput.Location = new System.Drawing.Point(546, 96);
            this.RentersInput.Name = "RentersInput";
            this.RentersInput.Size = new System.Drawing.Size(188, 23);
            this.RentersInput.TabIndex = 3;
            // 
            // TypeInput
            // 
            this.TypeInput.Location = new System.Drawing.Point(546, 125);
            this.TypeInput.Name = "TypeInput";
            this.TypeInput.Size = new System.Drawing.Size(188, 23);
            this.TypeInput.TabIndex = 3;
            // 
            // AddressInput
            // 
            this.AddressInput.Location = new System.Drawing.Point(546, 156);
            this.AddressInput.Name = "AddressInput";
            this.AddressInput.Size = new System.Drawing.Size(188, 23);
            this.AddressInput.TabIndex = 3;
            // 
            // HOAInput
            // 
            this.HOAInput.Location = new System.Drawing.Point(546, 186);
            this.HOAInput.Name = "HOAInput";
            this.HOAInput.Size = new System.Drawing.Size(188, 23);
            this.HOAInput.TabIndex = 3;
            // 
            // NotesInput
            // 
            this.NotesInput.Location = new System.Drawing.Point(324, 420);
            this.NotesInput.Multiline = true;
            this.NotesInput.Name = "NotesInput";
            this.NotesInput.Size = new System.Drawing.Size(410, 111);
            this.NotesInput.TabIndex = 3;
            // 
            // WorkHistoryList
            // 
            this.WorkHistoryList.FormattingEnabled = true;
            this.WorkHistoryList.ItemHeight = 15;
            this.WorkHistoryList.Location = new System.Drawing.Point(324, 275);
            this.WorkHistoryList.Name = "WorkHistoryList";
            this.WorkHistoryList.Size = new System.Drawing.Size(199, 109);
            this.WorkHistoryList.TabIndex = 0;
            // 
            // PayHistoryList
            // 
            this.PayHistoryList.FormattingEnabled = true;
            this.PayHistoryList.ItemHeight = 15;
            this.PayHistoryList.Location = new System.Drawing.Point(535, 273);
            this.PayHistoryList.Name = "PayHistoryList";
            this.PayHistoryList.Size = new System.Drawing.Size(199, 109);
            this.PayHistoryList.TabIndex = 0;
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddBtn.Location = new System.Drawing.Point(383, 549);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(83, 25);
            this.AddBtn.TabIndex = 4;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EditBtn.Location = new System.Drawing.Point(484, 549);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(83, 25);
            this.EditBtn.TabIndex = 4;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteBtn.Location = new System.Drawing.Point(582, 549);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(83, 25);
            this.DeleteBtn.TabIndex = 4;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // PropertiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(800, 645);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.PayHistoryList);
            this.Controls.Add(this.WorkHistoryList);
            this.Controls.Add(this.NotesInput);
            this.Controls.Add(this.HOAInput);
            this.Controls.Add(this.AddressInput);
            this.Controls.Add(this.TypeInput);
            this.Controls.Add(this.RentersInput);
            this.Controls.Add(this.OwnerInput);
            this.Controls.Add(this.NotesLabel);
            this.Controls.Add(this.HOALabel);
            this.Controls.Add(this.PayHistoryLabel);
            this.Controls.Add(this.HistoryLabel);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.RenterLabel);
            this.Controls.Add(this.OwnerLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PropertiesListBox);
            this.Name = "PropertiesForm";
            this.Text = "Properties";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox PropertiesListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label OwnerLabel;
        private System.Windows.Forms.Label RenterLabel;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label HistoryLabel;
        private System.Windows.Forms.Label PayHistoryLabel;
        private System.Windows.Forms.Label HOALabel;
        private System.Windows.Forms.Label NotesLabel;
        private System.Windows.Forms.TextBox OwnerInput;
        private System.Windows.Forms.TextBox RentersInput;
        private System.Windows.Forms.TextBox TypeInput;
        private System.Windows.Forms.TextBox AddressInput;
        private System.Windows.Forms.TextBox HOAInput;
        private System.Windows.Forms.TextBox NotesInput;
        private System.Windows.Forms.ListBox WorkHistoryList;
        private System.Windows.Forms.ListBox PayHistoryList;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button DeleteBtn;
    }
}

