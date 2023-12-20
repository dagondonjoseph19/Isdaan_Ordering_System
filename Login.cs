using OrderingSystem.AppData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderingSystem
{
    public partial class Login : Form
    {
        private String _szResponse;
        private UserRepository userRepo;

        public Login()
        {
            InitializeComponent();
            //
            _szResponse = String.Empty;
            //
            userRepo = new UserRepository();
        }

     

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TxtUsername.Text))
            {
                ErrorProvider.SetError(TxtUsername, "Empty Field!");
                return;
            }
            if (String.IsNullOrEmpty(TxtPassword.Text))
            {
                ErrorProvider.SetError(TxtPassword, "Empty Field!");
                return;
            }

            var userLogged = userRepo.GetUserByUsername(TxtUsername.Text);

            if (userLogged != null)
            {
                if (userLogged.Password.Equals(TxtPassword.Text))
                {
                    switch ((Roles)userLogged.RoleId)
                    {
                        case Roles.Admin:
                            // Load student Dashboard
                            new Form_Admin().Show();
                            this.Hide();
                            break;

                        case Roles.Seller:
                            // Load Teacher Dashboard
                            new Form_Seller().Show();
                            this.Hide();
                            break;

                        /*case Roles.Customer:
                            // Load Admin Dashboard
                            new Form_Seller().Show();
                            this.Hide();
                            break;*/
                        default:
                            MessageBox.Show("Log In Success");
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect Password");
                }
            }
            else
            {
                MessageBox.Show("Username not found");
            }
        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (ComboBoxShowPass.Checked)
                TxtPassword.UseSystemPasswordChar = false;
            else
                TxtPassword.UseSystemPasswordChar = true;
        }
    }
}
