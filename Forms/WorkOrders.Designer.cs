namespace PropertyFolio.Forms
{
    partial class WorkOrdersForm
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
            this.PropIDLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.NotesLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.IssuedByLabel = new System.Windows.Forms.Label();
            this.IssuedToLabel = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.CompletedBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.PropIDInput = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.AddressInput = new System.Windows.Forms.TextBox();
            this.IssuedByInput = new System.Windows.Forms.TextBox();
            this.IssuedToInput = new System.Windows.Forms.TextBox();
            this.IssuedToContactLabel = new System.Windows.Forms.Label();
            this.IssuedToContactInput = new System.Windows.Forms.TextBox();
            this.NotesInput = new System.Windows.Forms.TextBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.IncompleteButton = new System.Windows.Forms.Button();
            this.StatusInput = new System.Windows.Forms.Label();
            this.DateCompletedLabel = new System.Windows.Forms.Label();
            this.DateCompleted = new System.Windows.Forms.DateTimePicker();
            this.VendorLabel = new System.Windows.Forms.Label();
            this.PropertyLabel = new System.Windows.Forms.Label();
            this.OwnerPhoneInput = new System.Windows.Forms.TextBox();
            this.OwnerInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OwnerLabel = new System.Windows.Forms.Label();
            this.ResidentLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ResidentInput = new System.Windows.Forms.TextBox();
            this.ResidentPhoneInput = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PropIDLabel
            // 
            this.PropIDLabel.AutoSize = true;
            this.PropIDLabel.Location = new System.Drawing.Point(45, 166);
            this.PropIDLabel.Name = "PropIDLabel";
            this.PropIDLabel.Size = new System.Drawing.Size(69, 15);
            this.PropIDLabel.TabIndex = 0;
            this.PropIDLabel.Text = "Property ID:";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(401, 163);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(52, 15);
            this.AddressLabel.TabIndex = 0;
            this.AddressLabel.Text = "Address:";
            // 
            // NotesLabel
            // 
            this.NotesLabel.AutoSize = true;
            this.NotesLabel.Location = new System.Drawing.Point(73, 478);
            this.NotesLabel.Name = "NotesLabel";
            this.NotesLabel.Size = new System.Drawing.Size(41, 15);
            this.NotesLabel.TabIndex = 0;
            this.NotesLabel.Text = "Notes:";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(383, 344);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(70, 15);
            this.DateLabel.TabIndex = 0;
            this.DateLabel.Text = "Date Issued:";
            // 
            // IssuedByLabel
            // 
            this.IssuedByLabel.AutoSize = true;
            this.IssuedByLabel.Location = new System.Drawing.Point(57, 340);
            this.IssuedByLabel.Name = "IssuedByLabel";
            this.IssuedByLabel.Size = new System.Drawing.Size(59, 15);
            this.IssuedByLabel.TabIndex = 0;
            this.IssuedByLabel.Text = "Issued By:";
            // 
            // IssuedToLabel
            // 
            this.IssuedToLabel.AutoSize = true;
            this.IssuedToLabel.Location = new System.Drawing.Point(56, 376);
            this.IssuedToLabel.Name = "IssuedToLabel";
            this.IssuedToLabel.Size = new System.Drawing.Size(58, 15);
            this.IssuedToLabel.TabIndex = 0;
            this.IssuedToLabel.Text = "Issued To:";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Title.Location = new System.Drawing.Point(12, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(112, 25);
            this.Title.TabIndex = 0;
            this.Title.Text = "Work Order";
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.Transparent;
            this.CloseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CloseBtn.Location = new System.Drawing.Point(733, 12);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(33, 33);
            this.CloseBtn.TabIndex = 1;
            this.CloseBtn.Text = "X";
            this.CloseBtn.UseVisualStyleBackColor = false;
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.BackColor = System.Drawing.Color.Transparent;
            this.SubmitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SubmitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SubmitBtn.Location = new System.Drawing.Point(248, 615);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(83, 33);
            this.SubmitBtn.TabIndex = 1;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.UseVisualStyleBackColor = false;
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.Color.Transparent;
            this.EditBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EditBtn.Location = new System.Drawing.Point(349, 615);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(83, 33);
            this.EditBtn.TabIndex = 1;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = false;
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.Red;
            this.CancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelBtn.FlatAppearance.BorderSize = 0;
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CancelBtn.Location = new System.Drawing.Point(201, 19);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(104, 33);
            this.CancelBtn.TabIndex = 1;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // CompletedBtn
            // 
            this.CompletedBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.CompletedBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CompletedBtn.FlatAppearance.BorderSize = 0;
            this.CompletedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CompletedBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CompletedBtn.Location = new System.Drawing.Point(310, 20);
            this.CompletedBtn.Name = "CompletedBtn";
            this.CompletedBtn.Size = new System.Drawing.Size(104, 33);
            this.CompletedBtn.TabIndex = 1;
            this.CompletedBtn.Text = "Completed";
            this.CompletedBtn.UseVisualStyleBackColor = false;
            this.CompletedBtn.Click += new System.EventHandler(this.CompletedBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.Transparent;
            this.DeleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteBtn.Location = new System.Drawing.Point(448, 615);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(98, 33);
            this.DeleteBtn.TabIndex = 1;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            // 
            // PropIDInput
            // 
            this.PropIDInput.Location = new System.Drawing.Point(120, 160);
            this.PropIDInput.Name = "PropIDInput";
            this.PropIDInput.Size = new System.Drawing.Size(200, 23);
            this.PropIDInput.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(459, 338);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // AddressInput
            // 
            this.AddressInput.Location = new System.Drawing.Point(459, 160);
            this.AddressInput.Name = "AddressInput";
            this.AddressInput.Size = new System.Drawing.Size(200, 23);
            this.AddressInput.TabIndex = 2;
            // 
            // IssuedByInput
            // 
            this.IssuedByInput.Location = new System.Drawing.Point(120, 337);
            this.IssuedByInput.Name = "IssuedByInput";
            this.IssuedByInput.Size = new System.Drawing.Size(200, 23);
            this.IssuedByInput.TabIndex = 2;
            // 
            // IssuedToInput
            // 
            this.IssuedToInput.Location = new System.Drawing.Point(120, 373);
            this.IssuedToInput.Name = "IssuedToInput";
            this.IssuedToInput.Size = new System.Drawing.Size(200, 23);
            this.IssuedToInput.TabIndex = 2;
            // 
            // IssuedToContactLabel
            // 
            this.IssuedToContactLabel.AutoSize = true;
            this.IssuedToContactLabel.Location = new System.Drawing.Point(62, 411);
            this.IssuedToContactLabel.Name = "IssuedToContactLabel";
            this.IssuedToContactLabel.Size = new System.Drawing.Size(54, 15);
            this.IssuedToContactLabel.TabIndex = 0;
            this.IssuedToContactLabel.Text = "Phone #:";
            this.IssuedToContactLabel.Click += new System.EventHandler(this.ContactLlabel_Click);
            // 
            // IssuedToContactInput
            // 
            this.IssuedToContactInput.Location = new System.Drawing.Point(120, 407);
            this.IssuedToContactInput.Name = "IssuedToContactInput";
            this.IssuedToContactInput.Size = new System.Drawing.Size(200, 23);
            this.IssuedToContactInput.TabIndex = 2;
            // 
            // NotesInput
            // 
            this.NotesInput.Location = new System.Drawing.Point(120, 475);
            this.NotesInput.Multiline = true;
            this.NotesInput.Name = "NotesInput";
            this.NotesInput.Size = new System.Drawing.Size(539, 113);
            this.NotesInput.TabIndex = 2;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.StatusLabel.Location = new System.Drawing.Point(9, 20);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(71, 25);
            this.StatusLabel.TabIndex = 0;
            this.StatusLabel.Text = "Status:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.IncompleteButton);
            this.panel1.Controls.Add(this.StatusInput);
            this.panel1.Controls.Add(this.StatusLabel);
            this.panel1.Controls.Add(this.CancelBtn);
            this.panel1.Controls.Add(this.CompletedBtn);
            this.panel1.Location = new System.Drawing.Point(120, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 66);
            this.panel1.TabIndex = 4;
            // 
            // IncompleteButton
            // 
            this.IncompleteButton.BackColor = System.Drawing.Color.Black;
            this.IncompleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IncompleteButton.FlatAppearance.BorderSize = 0;
            this.IncompleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IncompleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IncompleteButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.IncompleteButton.Location = new System.Drawing.Point(420, 20);
            this.IncompleteButton.Name = "IncompleteButton";
            this.IncompleteButton.Size = new System.Drawing.Size(104, 33);
            this.IncompleteButton.TabIndex = 1;
            this.IncompleteButton.Text = "Incomplete";
            this.IncompleteButton.UseVisualStyleBackColor = false;
            this.IncompleteButton.Click += new System.EventHandler(this.IncompleteBtn_Click);
            // 
            // StatusInput
            // 
            this.StatusInput.AutoSize = true;
            this.StatusInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.StatusInput.Location = new System.Drawing.Point(86, 23);
            this.StatusInput.Name = "StatusInput";
            this.StatusInput.Size = new System.Drawing.Size(67, 21);
            this.StatusInput.TabIndex = 0;
            this.StatusInput.Text = "Pending";
            // 
            // DateCompletedLabel
            // 
            this.DateCompletedLabel.AutoSize = true;
            this.DateCompletedLabel.Location = new System.Drawing.Point(357, 376);
            this.DateCompletedLabel.Name = "DateCompletedLabel";
            this.DateCompletedLabel.Size = new System.Drawing.Size(96, 15);
            this.DateCompletedLabel.TabIndex = 0;
            this.DateCompletedLabel.Text = "Date Completed:";
            // 
            // DateCompleted
            // 
            this.DateCompleted.Location = new System.Drawing.Point(459, 373);
            this.DateCompleted.Name = "DateCompleted";
            this.DateCompleted.Size = new System.Drawing.Size(200, 23);
            this.DateCompleted.TabIndex = 3;
            // 
            // VendorLabel
            // 
            this.VendorLabel.AutoSize = true;
            this.VendorLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.VendorLabel.Location = new System.Drawing.Point(120, 313);
            this.VendorLabel.Name = "VendorLabel";
            this.VendorLabel.Size = new System.Drawing.Size(61, 21);
            this.VendorLabel.TabIndex = 5;
            this.VendorLabel.Text = "Vendor";
            // 
            // PropertyLabel
            // 
            this.PropertyLabel.AutoSize = true;
            this.PropertyLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.PropertyLabel.Location = new System.Drawing.Point(120, 138);
            this.PropertyLabel.Name = "PropertyLabel";
            this.PropertyLabel.Size = new System.Drawing.Size(76, 21);
            this.PropertyLabel.TabIndex = 5;
            this.PropertyLabel.Text = "Property:";
            // 
            // OwnerPhoneInput
            // 
            this.OwnerPhoneInput.Location = new System.Drawing.Point(459, 199);
            this.OwnerPhoneInput.Name = "OwnerPhoneInput";
            this.OwnerPhoneInput.Size = new System.Drawing.Size(200, 23);
            this.OwnerPhoneInput.TabIndex = 2;
            // 
            // OwnerInput
            // 
            this.OwnerInput.Location = new System.Drawing.Point(120, 199);
            this.OwnerInput.Name = "OwnerInput";
            this.OwnerInput.Size = new System.Drawing.Size(200, 23);
            this.OwnerInput.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(401, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phone #:";
            // 
            // OwnerLabel
            // 
            this.OwnerLabel.AutoSize = true;
            this.OwnerLabel.Location = new System.Drawing.Point(74, 202);
            this.OwnerLabel.Name = "OwnerLabel";
            this.OwnerLabel.Size = new System.Drawing.Size(45, 15);
            this.OwnerLabel.TabIndex = 0;
            this.OwnerLabel.Text = "Owner:";
            // 
            // ResidentLabel
            // 
            this.ResidentLabel.AutoSize = true;
            this.ResidentLabel.Location = new System.Drawing.Point(60, 240);
            this.ResidentLabel.Name = "ResidentLabel";
            this.ResidentLabel.Size = new System.Drawing.Size(55, 15);
            this.ResidentLabel.TabIndex = 0;
            this.ResidentLabel.Text = "Resident:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(401, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Phone #:";
            // 
            // ResidentInput
            // 
            this.ResidentInput.Location = new System.Drawing.Point(120, 237);
            this.ResidentInput.Name = "ResidentInput";
            this.ResidentInput.Size = new System.Drawing.Size(200, 23);
            this.ResidentInput.TabIndex = 2;
            // 
            // ResidentPhoneInput
            // 
            this.ResidentPhoneInput.Location = new System.Drawing.Point(459, 237);
            this.ResidentPhoneInput.Name = "ResidentPhoneInput";
            this.ResidentPhoneInput.Size = new System.Drawing.Size(200, 23);
            this.ResidentPhoneInput.TabIndex = 2;
            // 
            // WorkOrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(778, 679);
            this.Controls.Add(this.ResidentPhoneInput);
            this.Controls.Add(this.ResidentInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ResidentLabel);
            this.Controls.Add(this.OwnerLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OwnerInput);
            this.Controls.Add(this.OwnerPhoneInput);
            this.Controls.Add(this.PropertyLabel);
            this.Controls.Add(this.VendorLabel);
            this.Controls.Add(this.DateCompleted);
            this.Controls.Add(this.DateCompletedLabel);
            this.Controls.Add(this.NotesInput);
            this.Controls.Add(this.IssuedToContactInput);
            this.Controls.Add(this.IssuedToContactLabel);
            this.Controls.Add(this.IssuedToInput);
            this.Controls.Add(this.IssuedByInput);
            this.Controls.Add(this.AddressInput);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.PropIDInput);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.IssuedToLabel);
            this.Controls.Add(this.IssuedByLabel);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.NotesLabel);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.PropIDLabel);
            this.Controls.Add(this.panel1);
            this.Name = "WorkOrdersForm";
            this.Text = "Work Order";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PropIDLabel;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label NotesLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label IssuedByLabel;
        private System.Windows.Forms.Label IssuedToLabel;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button CompletedBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.TextBox PropIDInput;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox AddressInput;
        private System.Windows.Forms.TextBox IssuedByInput;
        private System.Windows.Forms.TextBox IssuedToInput;
        private System.Windows.Forms.Label IssuedToContactLabel;
        private System.Windows.Forms.TextBox IssuedToContactInput;
        private System.Windows.Forms.TextBox NotesInput;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label StatusInput;
        private System.Windows.Forms.Label DateCompletedLabel;
        private System.Windows.Forms.DateTimePicker DateCompleted;
        private System.Windows.Forms.Button IncompleteButton;
        private System.Windows.Forms.Label VendorLabel;
        private System.Windows.Forms.Label PropertyLabel;
        private System.Windows.Forms.TextBox OwnerPhoneInput;
        private System.Windows.Forms.TextBox OwnerInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label OwnerLabel;
        private System.Windows.Forms.Label ResidentLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ResidentInput;
        private System.Windows.Forms.TextBox ResidentPhoneInput;
    }
}

