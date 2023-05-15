using ClassUser;
using facturacion;
using ProductClass;
using SingIn;
using SingIn.Displays;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace Taller_2
{
    public partial class InventarioVendedores : Form
    {
        public InventarioVendedores()
        {
            InitializeComponent();
        }

        private void Inventario_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void productVendedoresConfigLoad()
        {
            int id = 0;
            string line;
            string branchUser = "";
            List<string> documentData = new List<string>();

            if (File.Exists(Program.productPath))
            {

                using (StreamReader sr = new StreamReader(Program.userLoginPath))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        documentData.Add(line);
                    }
                }
                for (int i = 0; i < documentData.Count; i++)
                {
                    string[] lineEdit = documentData[i].Split(',');

                    branchUser = lineEdit[3];
                    
                }
                
                documentData.Clear();

                using (StreamReader sr = new StreamReader(Program.productPath))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        documentData.Add(line);
                    }
                }
                for (int i = 0; i < documentData.Count; i++)
                {
                    string[] lineEdit = documentData[i].Split(',');
                    if (lineEdit[3] == branchUser) 
                    {
                        id++;
                        productBindingSource.Add(new Product()
                        {
                            Id = id,
                            Name = lineEdit[1],
                            Price = int.Parse(lineEdit[2]),
                            Branch = lineEdit[3],
                            Stock = int.Parse(lineEdit[4])

                        });
                    }
                    dgvVendedores.Refresh();

                }
            }
        }



        private void InventarioVendedores_Load(object sender, EventArgs e)
        {
            productVendedoresConfigLoad();
        }

        private void dgvVendedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {

        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            this.Hide();
            FacturacionVendedores facturacionVendedores = new FacturacionVendedores();
            facturacionVendedores.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            singInMenu singInMenu = new singInMenu();
            singInMenu.Show();
        }
    }
}

        
