﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dbsys.AppData;

namespace Dbsys
{
    
    public class UserRepository
    {
        private DBSYSEntities db;
        public UserRepository()
        {
            db = new DBSYSEntities();
        }

        public ErrorCode NewUser(UserAccount aUserAccount, ref String outMessage)
        {
            ErrorCode retValue = ErrorCode.Error;
            try
            {
                db.UserAccount.Add(aUserAccount);
                db.SaveChanges();

                outMessage = "Inserted";
                retValue = ErrorCode.Success;
            }
            catch (Exception ex)
            {
                outMessage = ex.Message;
                MessageBox.Show(ex.Message);
            }
            return retValue;
        }

 
        
        public ErrorCode UpdateUser(int? userId, UserAccount aUserAccount, ref String outMessage)
        {
            ErrorCode retValue = ErrorCode.Error;
            try
            {
                // Find the user with id
                UserAccount user = db.UserAccount.Where(m => m.userId == userId).FirstOrDefault();
                // Update the value of the retrieved user
                user.userName = aUserAccount.userName;
                user.userPassword = aUserAccount.userPassword;

                db.SaveChanges();       // Execute the update

                outMessage = "Updated";
                retValue = ErrorCode.Success;
            }
            catch (Exception ex)
            {
                outMessage = ex.Message;
                retValue = ErrorCode.Success;
                MessageBox.Show(ex.Message);
            }
            return retValue;

        }
        
        public ErrorCode RemoveUser(int? userId, ref String outMessage)
        {
            ErrorCode retValue = ErrorCode.Error;
            try
            {
                UserAccount user = db.UserAccount.Where(m => m.userId == userId).FirstOrDefault();
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

        public UserAccount GetUserByUsername(String username)
        {
            // re-initialize db object because sometimes data in the list not updated
            db = new DBSYSEntities();
            // SELECT TOP 1 * FROM USERACCOUNT WHERE userName == username
            return db.UserAccount.Where(s => s.userName == username).FirstOrDefault();
        }
        public List<UserAccount> UserAccounts()
        {
            db = new DBSYSEntities();

            return db.UserAccount.ToList();
        }

        public List<vw_all_user_role> AllUserRole()
        {
            db = new DBSYSEntities();

            return db.vw_all_user_role.ToList();
        }

        // Implement the SearchUserRole method here
        public List<vw_all_user_role> SearchUserRole(string searchTerm)
        {
            // Search for user roles based on the search term
            return db.vw_all_user_role.Where(u => u.Username.Contains(searchTerm) || u.Role.Contains(searchTerm)).ToList();
        }

    }
}
