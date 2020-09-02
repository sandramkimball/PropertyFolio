namespace PropertyFolio.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.LogoTitle = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.WorkOrdersBtn = new System.Windows.Forms.Button();
            this.VacanciesBtn = new System.Windows.Forms.Button();
            this.OwnersBtn = new System.Windows.Forms.Button();
            this.RentersBtn = new System.Windows.Forms.Button();
            this.TypesBtn = new System.Windows.Forms.Button();
            this.PropertiesBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LogoTitle
            // 
            this.LogoTitle.AutoSize = true;
            this.LogoTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.LogoTitle.Location = new System.Drawing.Point(101, 12);
            this.LogoTitle.Name = "LogoTitle";
            this.LogoTitle.Size = new System.Drawing.Size(128, 25);
            this.LogoTitle.TabIndex = 0;
            this.LogoTitle.Text = "PropertyFolio";
            // 
            // Logo
            // 
            this.Logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Logo.BackgroundImage")));
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Logo.Location = new System.Drawing.Point(12, 12);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(83, 85);
            this.Logo.TabIndex = 1;
            this.Logo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.WorkOrdersBtn);
            this.panel1.Controls.Add(this.VacanciesBtn);
            this.panel1.Controls.Add(this.OwnersBtn);
            this.panel1.Controls.Add(this.RentersBtn);
            this.panel1.Controls.Add(this.TypesBtn);
            this.panel1.Controls.Add(this.PropertiesBtn);
            this.panel1.Location = new System.Drawing.Point(12, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 359);
            this.panel1.TabIndex = 2;
            // 
            // WorkOrdersBtn
            // 
            this.WorkOrdersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WorkOrdersBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WorkOrdersBtn.Location = new System.Drawing.Point(0, 284);
            this.WorkOrdersBtn.Name = "WorkOrdersBtn";
            this.WorkOrdersBtn.Size = new System.Drawing.Size(217, 46);
            this.WorkOrdersBtn.TabIndex = 0;
            this.WorkOrdersBtn.Text = "Work Orders";
            this.WorkOrdersBtn.UseVisualStyleBackColor = true;
            this.WorkOrdersBtn.Click += new System.EventHandler(this.WorkOrdersBtn_Click);
            // 
            // VacanciesBtn
            // 
            this.VacanciesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VacanciesBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VacanciesBtn.Location = new System.Drawing.Point(0, 128);
            this.VacanciesBtn.Name = "VacanciesBtn";
            this.VacanciesBtn.Size = new System.Drawing.Size(217, 46);
            this.VacanciesBtn.TabIndex = 0;
            this.VacanciesBtn.Text = "Vacancies";
            this.VacanciesBtn.UseVisualStyleBackColor = true;
            this.VacanciesBtn.Click += new System.EventHandler(this.VacanciesBtn_Click);
            // 
            // OwnersBtn
            // 
            this.OwnersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OwnersBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OwnersBtn.Location = new System.Drawing.Point(0, 180);
            this.OwnersBtn.Name = "OwnersBtn";
            this.OwnersBtn.Size = new System.Drawing.Size(217, 46);
            this.OwnersBtn.TabIndex = 0;
            this.OwnersBtn.Text = "Owners";
            this.OwnersBtn.UseVisualStyleBackColor = true;
            this.OwnersBtn.Click += new System.EventHandler(this.OwnersBtn_Click);
            // 
            // RentersBtn
            // 
            this.RentersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RentersBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RentersBtn.Location = new System.Drawing.Point(0, 232);
            this.RentersBtn.Name = "RentersBtn";
            this.RentersBtn.Size = new System.Drawing.Size(217, 46);
            this.RentersBtn.TabIndex = 0;
            this.RentersBtn.Text = "Renters";
            this.RentersBtn.UseVisualStyleBackColor = true;
            this.RentersBtn.Click += new System.EventHandler(this.RentersBtn_Click);
            // 
            // TypesBtn
            // 
            this.TypesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TypesBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TypesBtn.Location = new System.Drawing.Point(0, 76);
            this.TypesBtn.Name = "TypesBtn";
            this.TypesBtn.Size = new System.Drawing.Size(217, 46);
            this.TypesBtn.TabIndex = 0;
            this.TypesBtn.Text = "Property Types";
            this.TypesBtn.UseVisualStyleBackColor = true;
            // 
            // PropertiesBtn
            // 
            this.PropertiesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PropertiesBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PropertiesBtn.Location = new System.Drawing.Point(0, 24);
            this.PropertiesBtn.Name = "PropertiesBtn";
            this.PropertiesBtn.Size = new System.Drawing.Size(217, 46);
            this.PropertiesBtn.TabIndex = 0;
            this.PropertiesBtn.Text = "Properties";
            this.PropertiesBtn.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(92, 491);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(603, 241);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(800, 697);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.LogoTitle);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LogoTitle;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button RentersBtn;
        private System.Windows.Forms.Button TypesBtn;
        private System.Windows.Forms.Button PropertiesBtn;
        private System.Windows.Forms.Button VacanciesBtn;
        private System.Windows.Forms.Button OwnersBtn;
        private System.Windows.Forms.Button WorkOrdersBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

