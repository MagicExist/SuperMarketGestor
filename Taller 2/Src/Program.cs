using ClassUser;
using SingIn;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Taller_2.Displays;

namespace SingIn
{
    internal static class Program
    {
        public static string subPath = Application.StartupPath;
        public static string path = Path.Combine(subPath, "usersData.txt");
        public static string productPath = Path.Combine(subPath, "productData.txt");
        public static string userLoginPath = Path.Combine(subPath, "userLoginData.txt");
        public static string FacturacionPath = Path.Combine(subPath, "Factura.txt");
        public static string UsersName;
        public static User Admin = new User("0", "Admin", "12345678", "Admin","All");
        [STAThread]
        static void Main()
        {
            using (StreamWriter writer = new StreamWriter(path,true))
            {
            }
            using (StreamWriter writer = new StreamWriter(productPath,true))
            {
            }
            using (StreamWriter writer = new StreamWriter(userLoginPath, true))
            {
            }
            using (StreamWriter writer = new StreamWriter(FacturacionPath, true))
            {
            }
            if (File.Exists(path))
            {
                using (StreamReader UsersDataReader = new StreamReader(path))
                {
                    UsersName = UsersDataReader.ReadToEnd();

                }

                if (UsersName.Contains("Admin"))
                { }
                else
                {
                    using (StreamWriter UsersDataWriter = new StreamWriter(path, true))
                    {
                        UsersDataWriter.WriteLine(string.Join(",", $"_{Admin.Id}", Admin.UserName, Admin.Password, Admin.Rol));
                    }
                }

            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new singInMenu());
        }
    }
}
