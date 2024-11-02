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
        public void ViewBooks()
        {
            ListViewBooks.CurrentCell = null;

            DataTable dt = new DataTable();

            dt.Columns.Add("ID");
            dt.Columns.Add("Title");
            dt.Columns.Add("Quantity");
            dt.Columns.Add("Authorname");
            dt.Columns.Add("Price");

            // Biến đếm để theo dõi số lượng hàng đã thêm
            int count = 0;
            int limit = 10; // Giới hạn số hàng

            foreach (Book book in _library.Books)
            {
                // Kiểm tra xem đã đủ số lượng hàng cần hiển thị chưa
                if (count < limit)
                {
                    dt.Rows.Add(book.Id, book.Title, book.Quantity, book.Authorname, book.Price);
                    count++;
                }
                else
                {
                    break;
                }
            }
            // Truyền dữ liệu vào DataGridView
            ListViewBooks.DataSource = dt;  
        }

        private void BackToMenu_Click(object sender, EventArgs e)
        {
            MenuManagement menuManagement = new MenuManagement(_library);
            menuManagement.Show();
            this.Hide();
        }
    }
}
