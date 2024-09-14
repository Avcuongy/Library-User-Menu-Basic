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
    public partial class MenuManagement : Form
    {
        public Library _library;
        public MenuManagement(Library library)
        {
            InitializeComponent();
            _library = library;
        }
        public void PrintBooks_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuListBook menuListBook = new MenuListBook(_library);
            menuListBook.Show();
        }

        private void Borrow_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuBorrow menuBorrow = new MenuBorrow(_library);
            menuBorrow.Show();
        }
    }
}