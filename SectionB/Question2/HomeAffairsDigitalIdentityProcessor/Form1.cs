using System;
using System.Windows.Forms;

namespace HomeAffairsDigitalIdentityProcessor
{
    public partial class Form1 : Form
    {
        private CitizenProfile _currentProfile;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string id = txtID.Text.Trim();
            string citizenship = cmbCitizenship.SelectedItem?.ToString() ?? string.Empty;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(id) || string.IsNullOrEmpty(citizenship))
            {
                lblValidationResult.Text = "Please fill in all fields and select citizenship status.";
                return;
            }

            _currentProfile = new CitizenProfile(name, id, citizenship);
            lblValidationResult.Text = _currentProfile.ValidateID();
        }

        private void btnGenerateProfile_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string id = txtID.Text.Trim();
            string citizenship = cmbCitizenship.SelectedItem?.ToString() ?? string.Empty;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(id) || string.IsNullOrEmpty(citizenship))
            {
                txtSummary.Text = "Please fill in all fields before generating a profile.";
                return;
            }

            _currentProfile = new CitizenProfile(name, id, citizenship);
            string validation = _currentProfile.ValidateID();
            string timestamp = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");

            txtSummary.Text =
                $"==== DIGITAL CITIZEN SUMMARY ====\r\n" +
                $"Name: {_currentProfile.FullName}\r\n" +
                $"ID Number: {_currentProfile.IDNumber}\r\n" +
                $"Age: {_currentProfile.Age}\r\n" +
                $"Citizenship: {_currentProfile.CitizenshipStatus}\r\n" +
                $"Validation: {validation}\r\n" +
                $"Processed at: Home Affairs Digital Desk\r\n" +
                $"Timestamp: {timestamp}";
        }
    }
}