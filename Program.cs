using CSharp_OOP_Lab_06;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Library lib = new Library();
            lib.addBook(new Book("B01", "The Great Adventure", "John Smith", new DateTime(2020, 5, 15), "Adventure Press", 320, 250, 10));
            lib.addBook(new Book("B02", "Mystery of the Ocean", "Alice Johnson", new DateTime(2019, 8, 22), "Oceanic Books", 275, 180, 5));
            lib.addBook(new Book("B03", "Tech Innovations", "Michael Brown", new DateTime(2021, 2, 10), "Tech Publishing", 420, 300, 8));
            lib.addBook(new Book("B04", "Journey Through Time", "Linda Davis", new DateTime(2018, 11, 30), "Historical Reads", 350, 220, 12));
            lib.addBook(new Book("B05", "Cooking Made Easy", "Emily Clark", new DateTime(2022, 7, 5), "Gourmet Publications", 240, 150, 15));
            lib.addBook(new Book("B06", "Space Explorers", "Robert Lee", new DateTime(2017, 4, 18), "Galactic Books", 320, 200, 7));
            lib.addBook(new Book("B07", "Secrets of the Mind", "Sarah Miller", new DateTime(2023, 1, 12), "Psychology Press", 280, 170, 6));
            lib.addBook(new Book("B08", "Ultimate Sports Guide", "Daniel Wilson", new DateTime(2020, 10, 25), "Sports Central", 310, 190, 9));
            lib.addBook(new Book("B09", "Art and Culture", "Jessica Martinez", new DateTime(2019, 6, 8), "Cultural Publishing", 330, 210, 11));
            lib.addBook(new Book("B10", "The Science of Happiness", "Matthew Anderson", new DateTime(2021, 3, 17), "Wellness Books", 290, 160, 13));

            lib.addUser(new User("L01", "U01"));
            lib.addUser(new User("L02", "U02"));
            lib.addUser(new User("L03", "U03"));
            lib.addUser(new User("L04", "U04"));
            lib.addUser(new User("L05", "U05"));
            lib.addUser(new User("L06", "U06"));
            lib.addUser(new User("L07", "U07"));
            lib.addUser(new User("L08", "U08"));
            lib.addUser(new User("L09", "U09"));
            lib.addUser(new User("L10", "U10"));


            Menu menuForm = new Menu(lib);
            Application.Run(menuForm);
        }
    }
}
