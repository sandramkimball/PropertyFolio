using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PropertyFolio.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            LoginError.Visible = false;
        }
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string username = UsernameInput.Text;
            string password = PasswordInput.Text;

            if (checkFields())
            {
                this.DialogResult = DialogResult.OK;
            }
            else 
            {
                LoginError.Visible = true;
            };
        }
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private Boolean checkFields()
        {
            if (UsernameInput.Text.Trim().Equals("") ||
                PasswordInput.Text.Trim().Equals("")
            )
            {
                return false;
            }
            return true;
        }
    }
}
