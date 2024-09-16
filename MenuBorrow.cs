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
    public partial class MenuBorrow : Form
    {
        private Library _Library;
        private string archive;

        public MenuBorrow(Library library)
        {
            InitializeComponent();
            _Library = library;
            ShowCombobox();
            BoxID.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowResultFindByCombobox();
        }
        public void ShowCombobox()
        {
            List<string> list = new List<string>();
            foreach (Book book in _Library.Books)
            {
                list.Add(book.Id);
            }
            BoxID.DataSource = list;
        }
        public void ShowResultFindByCombobox()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Title");
            dt.Columns.Add("Authorname");
            dt.Columns.Add("numofpages");
            dt.Columns.Add("Price");
            dt.Columns.Add("Quantity");

            foreach (Book book in _Library.Books)
            {
                if (book.Id == BoxID.SelectedItem.ToString())
                {
                    dt.Rows.Add(book.Id,book.Title,book.Authorname,book.Numofpages,book.Price,book.Quantity);
                }
            }

            ShowResultFind.DataSource = dt;

            ShowResultFind.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ShowResultFind.AutoResizeColumns();
            ShowResultFind.AutoResizeRows();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            byte count = (byte) int.Parse(CountBorrow.Text);   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuManagement menuManagement = new MenuManagement(_Library);
            this.Hide();
            menuManagement.Show();
        }
    }
}
