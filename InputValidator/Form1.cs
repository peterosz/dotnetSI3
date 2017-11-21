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

namespace InputValidatorForm
{
    public partial class InputValidator : Form
    {
        InputValidatorLogic validator = new InputValidatorLogic();

        public InputValidator()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!validator.ValidName(txtName.Text))
                MessageBox.Show("The name is invalid (only alphabetical characters are allowed)");
            
            if (!validator.ValidPhoneNumber(txtPhone.Text))
                txtPhone.Text = InputValidatorLogic.ReformatPhone(txtPhone.Text);

            if (!validator.ValidEmail(txtEmail.Text))
                MessageBox.Show("The e-mail address is not valid.");
        }

        

    }
}
