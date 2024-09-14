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
    public partial class MenuListBook : Form
    {
        private Library _library;
        public MenuListBook(Library library)
        {
            InitializeComponent();
            _library = library;
            ViewBooks();
        }

        private void ListViewBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        public void ViewBooks()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Title");
            dt.Columns.Add("Quantity");
            dt.Columns.Add("Authorname");
            dt.Columns.Add("Price");

            foreach (Book book in _library.Books)
            {
                dt.Rows.Add(book.Id, book.Title, book.Quantity,book.Authorname,book.Price);
            }

            // Truyền dữ liệu vào DataGridView
            ListViewBooks.DataSource = dt;
            
            // Điều Chỉnh Fit Giữa Các Column And Rows
            ListViewBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ListViewBooks.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void BackToMenu_Click(object sender, EventArgs e)
        {
            MenuManagement menuManagement = new MenuManagement(_library);
            menuManagement.Show();
            this.Hide();
        }
    }
}
