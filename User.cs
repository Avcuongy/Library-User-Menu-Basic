using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_OOP_Lab_06
{
    public class User : ICloneable
    {
        private string username;
        private string idUser;
        public User(string username, string idUser)
        {
            Username = username;
            this.idUser = idUser;
        }
        public string Username { get => username; set => username = value; }
        public string IdUser { get => idUser; set => idUser = value; }

        public object Clone()
        {
            return new User(Username, IdUser);
        }

        public override string ToString()
        {
            return $"User(Name: {Username}, ID: {IdUser})";
        }
    }
}