using OrderingSystem.AppData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderingSystem
{
    public class UserRepository
    {
        private Isda_Ordering_SystemEntities db;
        public UserRepository()
        {
            db = new Isda_Ordering_SystemEntities();
        }

        internal static object Login(string text1, object text2, ref string role, ref object szResponse)
        {
            throw new NotImplementedException();
        }

        public UserAccount GetUserByUsername(String username)
        {
            // re-initialize db object because sometimes data in the list not updated
            using (db = new Isda_Ordering_SystemEntities())
            {
                // SELECT TOP 1 * FROM USERACCOUNT WHERE userName == username
                return db.UserAccount.Where(s => s.Username == username).FirstOrDefault();
            }
        }

        public ErrorCode NewUser(UserAccount aUserAccount, ref String outMessage)
        {
            ErrorCode retValue = ErrorCode.Error;
            try
            {
                db.UserAccount.Add(aUserAccount);
                db.SaveChanges();

                outMessage = "Account Created";
                retValue = ErrorCode.Success;
            }
            catch (Exception ex)
            {
                outMessage = ex.Message;
                MessageBox.Show(ex.Message);
            }
            return retValue;
        }
        public ErrorCode UpdateUserUsingStoredProf(int uID, String fName, String lName, String uN, String uP, int rID, String uC, ref String szResponse)
        {
            using (db = new Isda_Ordering_SystemEntities())
            {
                try
                {
                    db.sp_UpdateUser1(uID, fName, lName, uN, uP, rID, uC);
                    szResponse = "Updated";
                    return ErrorCode.Success;
                }
                catch (Exception ex)
                {
                    szResponse = ex.Message;
                    return ErrorCode.Error;
                }
            }
        }

        public List<UserAccount> UserAccounts()
        {
            db = new Isda_Ordering_SystemEntities();

            return db.UserAccount.ToList();
        }


        public ErrorCode UpdateUser(int? userId, UserAccount aUserAccount, ref String outMessage)
        {
            ErrorCode retValue = ErrorCode.Error;
            try
            {
                // Find the user with id
                UserAccount user = db.UserAccount.Where(m => m.UserId == userId).FirstOrDefault();

                if (user != null)
                {
                    // Update the value of the retrieved user
                    user.Username = aUserAccount.Username;
                    user.Password = aUserAccount.Password;
                    user.ContactInfo = aUserAccount.ContactInfo;
                    user.FirstName = aUserAccount.FirstName;
                    user.LastName = aUserAccount.LastName;
                    user.RoleId = aUserAccount.RoleId;

                    db.SaveChanges(); // Execute the update

                    outMessage = "Updated";
                    retValue = ErrorCode.Success;
                }
                else
                {
                    outMessage = "User not found";
                }
            }
            catch (Exception ex)
            {
                outMessage = ex.Message;
                MessageBox.Show(ex.Message);
            }
            return retValue;
        }
        public List<vw_userList> UserList()
        {
            using (db = new Isda_Ordering_SystemEntities())
            {
                return db.vw_userList.ToList();
            }
        }
        public ErrorCode RemoveUser(int? userId, ref String outMessage)
        {
            ErrorCode retValue = ErrorCode.Error;
            try
            {
                UserAccount user = db.UserAccount.Where(m => m.UserId == userId).FirstOrDefault();
                // Remove the user
                db.UserAccount.Remove(user);
                db.SaveChanges();       // Execute the update

                outMessage = "Deleted";
                retValue = ErrorCode.Success;
            }
            catch (Exception ex)
            {
                outMessage = ex.Message;
                retValue = ErrorCode.Error;
                MessageBox.Show(ex.Message);
            }
            return retValue;
        }

    }
}
