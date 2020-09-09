namespace PropertyFolio.Forms
{
    partial class Vacancies
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vacancies));
            this.Title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PropertiesList = new System.Windows.Forms.ListBox();
            this.MainImage = new System.Windows.Forms.PictureBox();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.GalleryBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BedroomCount = new System.Windows.Forms.Label();
            this.BathCount = new System.Windows.Forms.Label();
            this.SqftCount = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MainImage)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Title.Location = new System.Drawing.Point(12, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(98, 25);
            this.Title.TabIndex = 0;
            this.Title.Text = "Vacancies";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(26, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Available Properties";
            // 
            // PropertiesList
            // 
            this.PropertiesList.FormattingEnabled = true;
            this.PropertiesList.ItemHeight = 15;
            this.PropertiesList.Location = new System.Drawing.Point(26, 75);
            this.PropertiesList.Name = "PropertiesList";
            this.PropertiesList.Size = new System.Drawing.Size(186, 334);
            this.PropertiesList.TabIndex = 2;
            // 
            // MainImage
            // 
            this.MainImage.BackColor = System.Drawing.Color.Transparent;
            this.MainImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MainImage.BackgroundImage")));
            this.MainImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MainImage.Location = new System.Drawing.Point(224, 14);
            this.MainImage.Name = "MainImage";
            this.MainImage.Size = new System.Drawing.Size(326, 221);
            this.MainImage.TabIndex = 3;
            this.MainImage.TabStop = false;
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.Transparent;
            this.CloseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CloseBtn.Location = new System.Drawing.Point(814, 12);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(34, 37);
            this.CloseBtn.TabIndex = 4;
            this.CloseBtn.Text = "X";
            this.CloseBtn.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.Price);
            this.panel1.Controls.Add(this.Address);
            this.panel1.Controls.Add(this.SqftCount);
            this.panel1.Controls.Add(this.BathCount);
            this.panel1.Controls.Add(this.BedroomCount);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.GalleryBtn);
            this.panel1.Controls.Add(this.MainImage);
            this.panel1.Location = new System.Drawing.Point(239, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(565, 584);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.Menu;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(237, 262);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(95, 59);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // GalleryBtn
            // 
            this.GalleryBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.GalleryBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GalleryBtn.FlatAppearance.BorderSize = 0;
            this.GalleryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GalleryBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GalleryBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GalleryBtn.Location = new System.Drawing.Point(37, 14);
            this.GalleryBtn.Name = "GalleryBtn";
            this.GalleryBtn.Size = new System.Drawing.Size(94, 30);
            this.GalleryBtn.TabIndex = 5;
            this.GalleryBtn.Text = "Gallery";
            this.GalleryBtn.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(37, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "Gallery";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // BedroomCount
            // 
            this.BedroomCount.AutoSize = true;
            this.BedroomCount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BedroomCount.Location = new System.Drawing.Point(37, 289);
            this.BedroomCount.Name = "BedroomCount";
            this.BedroomCount.Size = new System.Drawing.Size(87, 21);
            this.BedroomCount.TabIndex = 6;
            this.BedroomCount.Text = "2 Bedroom";
            // 
            // BathCount
            // 
            this.BathCount.AutoSize = true;
            this.BathCount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BathCount.Location = new System.Drawing.Point(130, 289);
            this.BathCount.Name = "BathCount";
            this.BathCount.Size = new System.Drawing.Size(73, 21);
            this.BathCount.TabIndex = 6;
            this.BathCount.Text = "1.5 Baths";
            // 
            // SqftCount
            // 
            this.SqftCount.AutoSize = true;
            this.SqftCount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SqftCount.Location = new System.Drawing.Point(209, 289);
            this.SqftCount.Name = "SqftCount";
            this.SqftCount.Size = new System.Drawing.Size(69, 21);
            this.SqftCount.TabIndex = 6;
            this.SqftCount.Text = "750 Sqft";
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Address.Location = new System.Drawing.Point(37, 268);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(285, 21);
            this.Address.TabIndex = 7;
            this.Address.Text = "100 Nampa Blvd, Nampa, Idaho 83000";
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.BackColor = System.Drawing.Color.Transparent;
            this.Price.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Price.ForeColor = System.Drawing.Color.Chocolate;
            this.Price.Location = new System.Drawing.Point(37, 229);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(121, 30);
            this.Price.TabIndex = 8;
            this.Price.Text = "$1250/mo";
            // 
            // Vacancies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(860, 666);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.PropertiesList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.panel1);
            this.Name = "Vacancies";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.MainImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox PropertiesList;
        private System.Windows.Forms.PictureBox MainImage;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label SqftCount;
        private System.Windows.Forms.Label BathCount;
        private System.Windows.Forms.Label BedroomCount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button GalleryBtn;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Label Price;
    }
}

