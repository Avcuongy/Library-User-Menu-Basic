using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;
using System.Runtime.Serialization;

namespace CSharp_OOP_Lab_06
{
    [Serializable]
    public class User : ISerializable
    {
        private string username;
        private string idUser;
        public User()
        {
           
        }
        public string Username { get => username; set => username = value; }
        public string IdUser { get => idUser; set => idUser = value; }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Username", Username);
            info.AddValue("Id", IdUser);
        }
        public User(SerializationInfo info, StreamingContext context)
        {
            Username = info.GetString("Username");
            IdUser = info.GetString("IdUser");
        }
        public override string ToString()
        {
            return $"User(Name: {Username}, ID: {IdUser})";
        }
    }
}