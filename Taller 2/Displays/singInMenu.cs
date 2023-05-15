using ClassUser;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using SingIn;
using Taller_2;

namespace SingIn
{

    public partial class singInMenu : Form
    {

        public static List<string> UsersDataObtaine = new List<string>();
        public static string data;
        public static string userName;
        public static string password;
        public static string rol;
        public static string branch;

        public singInMenu()
        {
            InitializeComponent();
        }


        private void txtBoxUser_Enter(object sender, EventArgs e) 
        {
            if (this.txtBoxUser.Text == "User" || this.txtBoxUser.Text == "")
            {
                this.txtBoxUser.Text = "";
                
            }
            else { }
        }
        private void txtBoxUser_Leave(object sender, EventArgs e)
        {

            if (this.txtBoxUser.Text == "User" || this.txtBoxUser.Text == "")
            {
                this.txtBoxUser.Text = "User";
            }
            else {}
        }

        private void txtBoxPassword_Enter(object sender, EventArgs e)
        {
            if (this.txtBoxPassword.Text == "Password" || this.txtBoxPassword.Text == "")
            {
                this.txtBoxPassword.Text = "";
            }
            else { }
        }
        private void txtBoxPassword_Leave(object sender, EventArgs e)
        {
            if (this.txtBoxPassword.Text == "Password" || this.txtBoxPassword.Text == "")
            {
                this.txtBoxPassword.Text = "Password";
            }
            else { }
        }

        private void btnSingIn_Click(object sender, EventArgs e)
        {

            if (File.Exists(Program.path)) 
            {

                using (StreamReader UsersDataReader = new StreamReader(Program.path))
                {
                    while ((data = UsersDataReader.ReadLine()) != null)
                    {
                        UsersDataObtaine.Add(data);
                    }
                }

                foreach (string userIterator in UsersDataObtaine)
                {

                      
                    if (userIterator.Contains("Admin") == true)
                    {
                        if (this.txtBoxUser.Text == Program.Admin.UserName && this.txtBoxPassword.Text == Program.Admin.Password)
                        {
                            using (StreamWriter writer = new StreamWriter(Program.userLoginPath))
                            {
                                writer.WriteLine(string.Join(",",Program.Admin.UserName, Program.Admin.Password, Program.Admin.Rol));
                            }
                            MessageBox.Show("Bienvenido Admin");
                            this.Hide();
                            Inventario inventario = new Inventario();
                            inventario.Show();
                            return;
                        }
                    }
                    else if (userIterator.Contains("Cajero"))
                    {
                        string[] userData = userIterator.Split(',');
                        userName = userData[1];
                        password = userData[2];
                        rol = userData[3];
                        branch = userData[4];
                        

                        if (this.txtBoxUser.Text == userName && this.txtBoxPassword.Text == password && rol == "Cajero")
                        {
                            using (StreamWriter writer = new StreamWriter(Program.userLoginPath))
                            {
                                writer.WriteLine(string.Join(",",userName, password, rol,branch));
                            }
                            MessageBox.Show("Bienvenido Cajero");
                            this.Hide();
                            InventarioVendedores inventarioVendedores = new InventarioVendedores();
                            inventarioVendedores.Show();
                            return;
                        }

                    }
                }
            }
            
           
            MessageBox.Show("UserName or Password incorrect!!!");
           
        }

        private void singInMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
