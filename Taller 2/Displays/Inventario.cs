using ClassUser;
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
using Taller_2.Displays;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace Taller_2
{
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
        }

        private void Inventario_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void productConfig(object idObtaine, int _case, object newValue)
        {
            string line;
            List<string> documentData = new List<string>();

            if (File.Exists(Program.productPath))
            {
                using (StreamReader sr = new StreamReader(Program.productPath))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        documentData.Add(line);
                    }
                }
                for (int i = 0; i < documentData.Count; i++)
                {
                    if (documentData[i].Contains(idObtaine.ToString()))
                    {
                        string[] lineEdit = documentData[i].Split(',');

                        lineEdit[_case] = newValue.ToString();
                        documentData[i] = string.Join(",", lineEdit);
                        break;
                    }
                }
                using (StreamWriter streamWriter = new StreamWriter(Program.productPath))
                {
                    for (int i = 0; i < documentData.Count; i++)
                    {
                        streamWriter.WriteLine(documentData[i]);
                    }
                    streamWriter.Close();
                }

            }
        }

        private void productConfigLoad()
        {
            string line;
            List<string> documentData = new List<string>();

            if (File.Exists(Program.productPath))
            {
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

                    lineEdit[0] = $"_{(i).ToString()}";

                    productBindingSource.Add(new Product()
                    {
                        Id = i,
                        Name = lineEdit[1],
                        Price = int.Parse(lineEdit[2]),
                        Branch = lineEdit[3],
                        Stock = int.Parse(lineEdit[4])
                        
                    });
                    dataGridView1.Refresh();
                    

                    documentData[i] = string.Join(",", lineEdit);
                }
                using (StreamWriter streamWriter = new StreamWriter(Program.productPath))
                {
                    for (int i = 0; i < documentData.Count; i++)
                    {
                        streamWriter.WriteLine(documentData[i]);
                    }
                    streamWriter.Close();
                }

            }
        }

        private void productConfigDelete(object idObtaine)
        {
            string line;
            List<string> documentData = new List<string>();

            if (File.Exists(Program.productPath))
            {
                using (StreamReader sr = new StreamReader(Program.productPath))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        documentData.Add(line);
                    }
                }
                for (int i = 0; i < documentData.Count; i++)
                {
                    if (documentData[i].Contains(idObtaine.ToString()))
                    {
                        documentData.RemoveAt(i);
                        break;
                    }
                }
                using (StreamWriter streamWriter = new StreamWriter(Program.productPath))
                {
                    for (int i = 0; i < documentData.Count; i++)
                    {
                        streamWriter.WriteLine(documentData[i]);
                    }
                    streamWriter.Close();
                }

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                object idObtaine = dataGridView1.Rows[e.RowIndex].Cells[0].Value;

                if (File.Exists(Program.productPath))
                {
                    productConfigDelete(idObtaine);
                    while (dataGridView1.Rows.Count > 0)
                    {
                        dataGridView1.Rows.RemoveAt(dataGridView1.Rows.Count - 1);
                    }
                    productConfigLoad();
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbBoxProduct.SelectedItem.ToString() != "" && txtBoxPrice.Text != "" && txtBoxStock.Text != "" && cbBoxBranch.SelectedItem != null)
            {
                try
                {
                    string productName = cbBoxProduct.SelectedItem.ToString();
                    string price = txtBoxPrice.Text;
                    string stock = txtBoxStock.Text;
                    string branch = cbBoxBranch.SelectedItem.ToString();
                    string line;
                    bool crear = false;
                    List<string> documentData = new List<string>();
                    int id = File.ReadLines(Program.productPath).Count();

                    if (File.Exists(Program.productPath))
                    {

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

                            if (lineEdit[1] == productName && lineEdit[2] == price && lineEdit[3] == branch) 
                            {
                                lineEdit[4]  = (int.Parse(lineEdit[4]) + int.Parse(stock)).ToString();
                                crear = true;
                            }

                            documentData[i] = string.Join(",", lineEdit);
                        }





                        if (crear == false)
                        {

                            using (StreamWriter streamWriter = new StreamWriter(Program.productPath, true))
                            {

                                streamWriter.WriteLine(string.Join(",", $"_{id + 1}", productName, price, branch, stock));

                                productBindingSource.Add(new Product()
                                {
                                    Id = id+1,
                                    Name = productName,
                                    Price = int.Parse(price),
                                    Branch = branch,
                                    Stock = int.Parse(stock)

                                });
                                
                                streamWriter.Close();
                            }
                        }
                        else
                        {
                            using (StreamWriter streamWriter = new StreamWriter(Program.productPath))
                            {
                                for (int i = 0; i < documentData.Count; i++)
                                {
                                    streamWriter.WriteLine(documentData[i]);
                                }
                                streamWriter.Close();
                            }
                        }
                        crear = false;
                        while (dataGridView1.Rows.Count > 0)
                        {
                            dataGridView1.Rows.RemoveAt(dataGridView1.Rows.Count - 1);
                        }
                        productConfigLoad();
                    }
                }
                catch
                {
                    Console.WriteLine("Error en btnUserCreator_Click");
                }
            }
            else { Console.WriteLine("Algun Campo Esta Vacio"); }
        }

        private void txtBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void txtBoxStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void txtBoxPrice_Enter(object sender, EventArgs e)
        {
            if (this.txtBoxPrice.Text == "Price" || this.txtBoxPrice.Text == "")
            {
                this.txtBoxPrice.Text = "";

            }
            else { }
        }

        private void txtBoxPrice_Leave(object sender, EventArgs e)
        {
            if (this.txtBoxPrice.Text == "Price" || this.txtBoxPrice.Text == "")
            {
                this.txtBoxPrice.Text = "Price";
            }
            else { }
        }

        private void txtBoxStock_Enter(object sender, EventArgs e)
        {
            if (this.txtBoxStock.Text == "Stock" || this.txtBoxStock.Text == "")
            {
                this.txtBoxStock.Text = "";

            }
            else { }
        }

        private void txtBoxStock_Leave(object sender, EventArgs e)
        {
            if (this.txtBoxStock.Text == "Stock" || this.txtBoxStock.Text == "")
            {
                this.txtBoxStock.Text = "Stock";

            }
            else { }
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            if (File.Exists(Program.productPath))
            {

                productConfigLoad();

            }
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            Users users = new Users();
            users.Show();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                object newValue = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                object idObtaine = dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                int _case;

                if (File.Exists(Program.path))
                {
                    switch (e.ColumnIndex)
                    {
                        
                        case 1:
                            _case = 1;
                            productConfig(idObtaine, _case, newValue);
                            break;
                        case 2:
                            _case = 2;
                            productConfig(idObtaine, _case, newValue);
                            break;
                        case 3:
                            _case = 3;
                            productConfig(idObtaine, _case, newValue);
                            break;
                        case 4:
                            _case = 4;
                            productConfig(idObtaine, _case, newValue);
                            break;
                    }

                }

            }

            catch
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            singInMenu singInMenu = new singInMenu();
            singInMenu.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Statistics statistics = new Statistics();
            statistics.Show();
        }
    }
}
