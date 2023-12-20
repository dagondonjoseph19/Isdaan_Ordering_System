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
    public partial class Form_Admin : Form
    {
        public List<Roles> listRole;
        UserRepository Repo;
        int userSelectedId = 0;
        Isda_Ordering_SystemEntities db;

        public Form_Admin()
        {
            InitializeComponent();
            listRole = new List<Roles>();
        }

        private void Form_Admin_Load(object sender, EventArgs e)
        {          
            Repo = new UserRepository();
            loadUser();
            cbRole.Text = "";
            loadRoleComboBox();
        }

        private void loadUser()
        {
            DataGridView_Admin.DataSource = Repo.UserList();
        }

        private void BTRegister_Click(object sender, EventArgs e)
        {
            db = new Isda_Ordering_SystemEntities();

            String username = TxtUsername.Text;
            String pass = TxtPassword.Text;
            String FirstName = TxtFirstName.Text;
            String LastName = TxtLastName.Text;
            String Contact = TxtContact.Text;
            String Role = cbRole.Text;

            String strOutputMsg = "";
            // Validation not allow empty or null value


            if (String.IsNullOrEmpty(FirstName))
            {
                ErrorProviderFirstName.SetError(TxtFirstName, "Empty Field!");
                return;
            }
            else

             if (String.IsNullOrEmpty(LastName))
            {
                ErrorProviderLastName.SetError(TxtLastName, "Empty Field!");
                return;
            }
            else

            if (String.IsNullOrEmpty(Role))
            {
                ErrorProviderRole.SetError(cbRole, "Empty Field!");
                return;
            }

            else

            if (String.IsNullOrEmpty(username))
            {
                ErrorProviderUsername.SetError(TxtUsername, "Empty Field!");
                return;
            }
            else
            // Validation not allow empty or null value
            if (String.IsNullOrEmpty(pass))
            {
                ErrorProviderPassword.SetError(TxtPassword, "Empty Field!");
                return;
            }
            else
            // Validation not allow empty or null value
            if (String.IsNullOrEmpty(Contact))
            {
                ErrorProviderContact.SetError(TxtContact, "Empty Field!");
                return;
            }


            // Create new object of USER_ACCOUNT
            UserAccount newUserAcc = new UserAccount();
            newUserAcc.Username = TxtUsername.Text;
            newUserAcc.Password = TxtPassword.Text;
            newUserAcc.RoleId = cbRole.SelectedIndex;
            newUserAcc.ContactInfo = TxtContact.Text;
            newUserAcc.FirstName = TxtFirstName.Text;
            newUserAcc.LastName = TxtLastName.Text;

            ErrorCode retValue = Repo.NewUser(newUserAcc, ref strOutputMsg);
            if (retValue == ErrorCode.Success)
            {
                //Clear the errors
                ErrorProviderUsername.Clear();
                MessageBox.Show(strOutputMsg, "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadUser();

                TxtPassword.Clear();
                TxtUsername.Clear();
                TxtContact.Clear();
                TxtFirstName.Clear();
                TxtLastName.Clear();
                cbRole.ResetText();

            }
            else
            {
                // error 
                MessageBox.Show(strOutputMsg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void loadRoleComboBox()
        {
            using (db = new Isda_Ordering_SystemEntities())
            {

                cbRole.DataSource = db.Roles;
            }
              
        }

        private void DataGridView_Admin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                userSelectedId = (Int32)DataGridView_Admin.Rows[e.RowIndex].Cells[0].Value;
                //TxtUsername.Text = DataGridView_Admin.Rows[e.RowIndex].Cells[3].Value as String;
                //TxtPassword.Text = DataGridView_Admin.Rows[e.RowIndex].Cells[4].Value as String;
                //TxtFirstName.Text = DataGridView_Admin.Rows[e.RowIndex].Cells[1].Value as String;
                //TxtLastName.Text = DataGridView_Admin.Rows[e.RowIndex].Cells[2].Value as String;
                //TxtContact.Text = DataGridView_Admin.Rows[e.RowIndex].Cells[6].Value as String;
                //cbRole.SelectedIndex = (Int32)DataGridView_Admin.Rows[e.RowIndex].Cells[5].Value - 1;
                TxtUsername.Text = DataGridView_Admin.Rows[e.RowIndex].Cells["Username"].Value.ToString();
                TxtPassword.Text = DataGridView_Admin.Rows[e.RowIndex].Cells["Password"].Value.ToString();
                TxtFirstName.Text = DataGridView_Admin.Rows[e.RowIndex].Cells["FirstName"].Value.ToString();
                TxtLastName.Text = DataGridView_Admin.Rows[e.RowIndex].Cells["LastName"].Value.ToString();
                cbRole.Text = DataGridView_Admin.Rows[e.RowIndex].Cells["RoleId"].Value.ToString();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception : {ex.Message}");
            }
        }

        private void BTUpdate_Click(object sender, EventArgs e)
        {
            /*String username = TxtUsername.Text;
            String pass = TxtPassword.Text;
            String fname = TxtFirstName.Text;
            String lname = TxtLastName.Text;
            String con = TxtContact.Text;
            int role = RoleComboBox.SelectedIndex;


            String strOutputMsg = "";

            // Validation not allow empty or null value
            if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(pass) || String.IsNullOrEmpty(fname))
            {
                ErrorProviderUsername.SetError(TxtUsername, "All fields must be filled!");
                return;
            }

            var userAccount = Repo.GetUserByUsername(username);

            if (userAccount != null)
            {
                // Update userAccount with new values
                userAccount.Password = pass;
                userAccount.FirstName = fname;
                userAccount.LastName = lname;
                userAccount.ContactInfo = con;
                userAccount.RoleId = role;

                ErrorCode retValue = Repo.UpdateUser(userSelectedId, userAccount, ref strOutputMsg);

                if (retValue == ErrorCode.Success)
                {
                    // Clear the errors
                    ErrorProviderUsername.Clear();
                    MessageBox.Show(strOutputMsg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadUser();
                    // Reset the selected id
                    userSelectedId = null;

                    TxtPassword.Clear();
                    TxtUsername.Clear();
                    TxtContact.Clear();
                    TxtFirstName.Clear();
                    TxtLastName.Clear();
                    RoleComboBox.ResetText();
                }
                else
                {
                    // Error
                    MessageBox.Show(strOutputMsg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                // User not found
                MessageBox.Show("User not found.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }*/
            String strOutputMsg = "";
            ErrorCode retValue = Repo.UpdateUserUsingStoredProf(userSelectedId, TxtFirstName.Text, TxtLastName.Text, TxtUsername.Text, TxtPassword.Text, cbRole.SelectedIndex + 1, TxtContact.Text, ref strOutputMsg);
            if (retValue != ErrorCode.Success)
            {
                MessageBox.Show(strOutputMsg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else 
            {
                ErrorProviderUsername.Clear();
                MessageBox.Show(strOutputMsg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadUser();
                //reset the selected id
                userSelectedId = 0;

                TxtPassword.Clear();
                TxtUsername.Clear();
                TxtContact.Clear();
                TxtFirstName.Clear();
                TxtLastName.Clear();
                cbRole.ResetText();
            }
        }

        private void BTDelete_Click(object sender, EventArgs e)
        {
            String username = TxtUsername.Text;
            String pass = TxtPassword.Text;

            String strOutputMsg = "";

            if (userSelectedId == 0)
            {
                MessageBox.Show("No User Selected", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            ErrorCode retValue = Repo.RemoveUser(userSelectedId, ref strOutputMsg);
            if (retValue == ErrorCode.Success)
            {
                //Clear the errors
                ErrorProviderUsername.Clear();
                MessageBox.Show(strOutputMsg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadUser();
                //reset the selected id
                userSelectedId = 0;

                TxtPassword.Clear();
                TxtUsername.Clear();
                TxtContact.Clear();
                TxtFirstName.Clear();
                TxtLastName.Clear();
                cbRole.ResetText();
            }
            else
            {
                // error 
                MessageBox.Show(strOutputMsg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void RoleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DataGridView_Admin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            userSelectedId = (Int32)DataGridView_Admin.Rows[e.RowIndex].Cells[0].Value;
            TxtUsername.Text = DataGridView_Admin.Rows[e.RowIndex].Cells[3].Value as String;
            TxtPassword.Text = DataGridView_Admin.Rows[e.RowIndex].Cells[4].Value as String;
            TxtFirstName.Text = DataGridView_Admin.Rows[e.RowIndex].Cells[1].Value as String;
            TxtLastName.Text = DataGridView_Admin.Rows[e.RowIndex].Cells[2].Value as String;
            TxtContact.Text = DataGridView_Admin.Rows[e.RowIndex].Cells[6].Value as String;
            cbRole.Text = DataGridView_Admin.Rows[e.RowIndex].Cells[5].Value as String;
        }

        private void cbRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
