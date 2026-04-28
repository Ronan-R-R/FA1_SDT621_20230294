using System.Drawing;
using System.Windows.Forms;

namespace HomeAffairsDigitalIdentityProcessor
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblCitizen = new System.Windows.Forms.Label();
            this.cmbCitizenship = new System.Windows.Forms.ComboBox();
            this.btnValidate = new System.Windows.Forms.Button();
            this.lblValidationResult = new System.Windows.Forms.Label();
            this.txtSummary = new System.Windows.Forms.TextBox();
            this.btnGenerateProfile = new System.Windows.Forms.Button();
            this.picCoatOfArms = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCoatOfArms)).BeginInit();
            this.SuspendLayout();

            // picCoatOfArms — left side decorative placeholder
            this.picCoatOfArms.BackColor = System.Drawing.Color.FromArgb(210, 120, 80);
            this.picCoatOfArms.Location = new System.Drawing.Point(0, 0);
            this.picCoatOfArms.Name = "picCoatOfArms";
            this.picCoatOfArms.Size = new System.Drawing.Size(200, 500);
            this.picCoatOfArms.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCoatOfArms.TabIndex = 99;
            this.picCoatOfArms.TabStop = false;
            // To show the coat of arms image, set:
            // this.picCoatOfArms.ImageLocation = @"path\to\coat_of_arms.png";

            // lblTitle
            this.lblTitle.AutoSize = false;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(0, 100, 0);
            this.lblTitle.Location = new System.Drawing.Point(205, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(460, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Home Affairs Digital Identity Processor";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblName
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblName.Location = new System.Drawing.Point(210, 80);
            this.lblName.Name = "lblName";
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Enter your Name:";

            // txtName
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtName.Location = new System.Drawing.Point(370, 77);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(270, 27);
            this.txtName.TabIndex = 2;

            // lblID
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblID.Location = new System.Drawing.Point(210, 125);
            this.lblID.Name = "lblID";
            this.lblID.TabIndex = 3;
            this.lblID.Text = "Enter your ID:";

            // txtID
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtID.Location = new System.Drawing.Point(370, 122);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(270, 27);
            this.txtID.TabIndex = 4;

            // lblCitizen
            this.lblCitizen.AutoSize = true;
            this.lblCitizen.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCitizen.Location = new System.Drawing.Point(210, 170);
            this.lblCitizen.Name = "lblCitizen";
            this.lblCitizen.TabIndex = 5;
            this.lblCitizen.Text = "Choose your Citizen:";

            // cmbCitizenship
            this.cmbCitizenship.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCitizenship.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCitizenship.Items.AddRange(new object[] {
                "South African",
                "Permanent Resident",
                "Visitor"
            });
            this.cmbCitizenship.Location = new System.Drawing.Point(370, 167);
            this.cmbCitizenship.Name = "cmbCitizenship";
            this.cmbCitizenship.Size = new System.Drawing.Size(270, 28);
            this.cmbCitizenship.TabIndex = 6;

            // btnValidate
            this.btnValidate.BackColor = System.Drawing.Color.FromArgb(0, 160, 0);
            this.btnValidate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValidate.FlatAppearance.BorderSize = 0;
            this.btnValidate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnValidate.ForeColor = System.Drawing.Color.White;
            this.btnValidate.Location = new System.Drawing.Point(500, 215);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(140, 35);
            this.btnValidate.TabIndex = 7;
            this.btnValidate.Text = "Validate ID";
            this.btnValidate.UseVisualStyleBackColor = false;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);

            // lblValidationResult
            this.lblValidationResult.AutoSize = false;
            this.lblValidationResult.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblValidationResult.Location = new System.Drawing.Point(370, 260);
            this.lblValidationResult.Name = "lblValidationResult";
            this.lblValidationResult.Size = new System.Drawing.Size(290, 25);
            this.lblValidationResult.TabIndex = 8;
            this.lblValidationResult.Text = "";

            // txtSummary
            this.txtSummary.BackColor = System.Drawing.Color.FromArgb(240, 200, 170);
            this.txtSummary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSummary.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSummary.Location = new System.Drawing.Point(215, 295);
            this.txtSummary.Multiline = true;
            this.txtSummary.Name = "txtSummary";
            this.txtSummary.ReadOnly = true;
            this.txtSummary.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSummary.Size = new System.Drawing.Size(445, 155);
            this.txtSummary.TabIndex = 9;

            // btnGenerateProfile
            this.btnGenerateProfile.BackColor = System.Drawing.Color.FromArgb(0, 160, 0);
            this.btnGenerateProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateProfile.FlatAppearance.BorderSize = 0;
            this.btnGenerateProfile.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGenerateProfile.ForeColor = System.Drawing.Color.White;
            this.btnGenerateProfile.Location = new System.Drawing.Point(460, 462);
            this.btnGenerateProfile.Name = "btnGenerateProfile";
            this.btnGenerateProfile.Size = new System.Drawing.Size(160, 35);
            this.btnGenerateProfile.TabIndex = 10;
            this.btnGenerateProfile.Text = "Generate profile";
            this.btnGenerateProfile.UseVisualStyleBackColor = false;
            this.btnGenerateProfile.Click += new System.EventHandler(this.btnGenerateProfile_Click);

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(225, 150, 110);
            this.ClientSize = new System.Drawing.Size(680, 510);
            this.Controls.Add(this.picCoatOfArms);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblCitizen);
            this.Controls.Add(this.cmbCitizenship);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.lblValidationResult);
            this.Controls.Add(this.txtSummary);
            this.Controls.Add(this.btnGenerateProfile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picCoatOfArms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblCitizen;
        private System.Windows.Forms.ComboBox cmbCitizenship;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.Label lblValidationResult;
        private System.Windows.Forms.TextBox txtSummary;
        private System.Windows.Forms.Button btnGenerateProfile;
        private System.Windows.Forms.PictureBox picCoatOfArms;
    }
}