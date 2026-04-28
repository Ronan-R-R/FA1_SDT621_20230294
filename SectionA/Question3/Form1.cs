using System;
using System.Windows.Forms;

namespace Question3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string language = txtLanguage.Text.Trim();

            if (string.IsNullOrEmpty(language))
            {
                MessageBox.Show("Please enter a programming language.", "Empty Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (string item in lstLanguages.Items)
            {
                if (item.Equals(language, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show($"'{language}' is already in the list.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtLanguage.Clear();
                    return;
                }
            }

            lstLanguages.Items.Add(language);
            txtLanguage.Clear();
            lblStatus.Text = string.Empty;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstLanguages.SelectedItem == null)
            {
                MessageBox.Show("Please select a language to remove.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string removed = lstLanguages.SelectedItem.ToString();
            lstLanguages.Items.Remove(lstLanguages.SelectedItem);
            lblStatus.Text = $"Removed '{removed}' at {DateTime.Now:dd MMM yyyy HH:mm:ss}";
        }
    }
}