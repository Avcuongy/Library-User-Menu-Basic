using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management
{
    public partial class Menu : Form
    {
        private Library _library;
        public Menu(Library library)
        {
            InitializeComponent();
            _library = library;
        }
        public void Login_Click(object sender, EventArgs e)
        {

            string userName = UsernameInput.Text;
            string password = PasswordInput.Text;

            if (_library.CheckUserLogin(userName,password))
            {
                MessageBox.Show("Login Successful!");
                this.Hide();
                MenuManagement menuManage = new MenuManagement(_library);
                menuManage.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
