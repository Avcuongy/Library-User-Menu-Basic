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
    public partial class CheckBook : Form
    {
        private Library _library;
        public CheckBook(Library library)
        {
            InitializeComponent();
            _library = library;
            SelectBook();
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = comboBox1.SelectedItem as string;
            if (s == "B01") 
            {
                textBox1.Text = "1";
                textBox2.Text = "2";
                textBox3.Text = "3";
            }
        }
        public void SelectBook()
        {
            List<String> list = new List<String>();
            foreach (Book book in _library.Books)
            {
                list.Add(book.Id);
            }
            comboBox1.DataSource = list;
        }
    }
}
