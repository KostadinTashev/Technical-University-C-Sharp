using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Welcome.Others;

namespace Welcome.Model
{
    internal class User
    {
        private string _names;
        private string _password;
        private UserRolesEnum _roles;
        private string _facultyNumber;
        private string _email;

        public string Names
        {
            get { return _names; }
            set { _names = value; }
        }
        public string Password
        {
            get { return DecryptPassword(_password); }
            set { _password = value; }
        }
        public string EcryptedPassword
        {
            get { return EncryptPassword(_password); }
            set { _password = EncryptPassword(value); }
        }
        public UserRolesEnum Role
        {
            get { return _roles; }
            set { _roles = value; }
        }
        public string FacultyNumber
        {
            get { return _facultyNumber; }
            set { _facultyNumber = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        private string EncryptPassword(string password)
        {
            StringBuilder encryptedPassword = new StringBuilder();
            for (int i = 0; i < password.Length; i++)
            {
                encryptedPassword.Append('*');
            }
            return encryptedPassword.ToString();
        }
        private string DecryptPassword(string encryptedPassword)
        {
            return _password;
        }
    }
}