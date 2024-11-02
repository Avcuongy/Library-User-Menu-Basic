using CSharp_OOP_Lab_06;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;

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

            Library lib;

            string file = "Data_Library.dat";

            string fileContent = File.ReadAllText(file);

            lib = JsonSerializer.Deserialize<Library>(fileContent);

            Menu menuForm = new Menu(lib);

            Application.Run(menuForm);
        }
    }
}
