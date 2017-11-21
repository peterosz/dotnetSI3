using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace InputValidator
{
    public partial class InputValidator : Form
    {
        public InputValidator()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidName(txtName.Text))
                MessageBox.Show("The name is invalid (only alphabetical characters are allowed)");
            
            if (!ValidPhoneNumber(txtPhone.Text))
                MessageBox.Show("The phone number is not a valid EU phone number");

            if (!ValidEmail(txtEmail.Text))
                MessageBox.Show("The e-mail address is not valid.");
            MessageBox.Show("Saved");
        }

        private bool ValidEmail(string email)
        {
            if (Regex.IsMatch(email, @"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$"))
                return true;
            return false;
        }

        private bool ValidPhoneNumber(string phoneNumber)
        {
            if (Regex.IsMatch(phoneNumber, @"((\+[0-9]{2})|0)[.\- ]?9[0-9]{2}[.\- ]?[0-9]{3}[.\- ]?[0-9]{4}"))
                return true;
            return false;
        }

        private bool ValidName(string name)
        {
            if (Regex.IsMatch(name, @"^([A-Za-z]*\s*)+$"))
                return true;
            return false;
        }

    }
}
