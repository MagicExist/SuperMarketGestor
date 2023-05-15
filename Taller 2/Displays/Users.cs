using ClassUser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Taller_2;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SingIn.Displays
{
    public partial class Users : Form
    {


        public static int __id = 0;

        public Users()
        {
            InitializeComponent();

        }

        private void Users_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void userConfigLoad()
        {
            string line;
            List<string> documentData = new List<string>();

            if (File.Exists(Program.path))
            {
                using (StreamReader sr = new StreamReader(Program.path))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        documentData.Add(line);
                    }
                }
                for (int i = 0; i < documentData.Count; i++)
                {
                    
                    Console.WriteLine("Este es el id: " + i);
                    if (documentData[i].Contains("Admin"))
                    {

                    }
                    else 
                    {
                        string[] lineEdit = documentData[i].Split(',');

                        lineEdit[0] = $"_{(i).ToString()}";

                        userBindingSource.Add(new User($"_{(i).ToString()}", lineEdit[1], lineEdit[2], lineEdit[3], lineEdit[4]));
                        dgvUsersData.Refresh();

                        documentData[i] = string.Join(",", lineEdit);
                        
                    }

                    
                    
                }
                using (StreamWriter streamWriter = new StreamWriter(Program.path))
                {
                    for (int i = 0; i < documentData.Count; i++)
                    {
                        streamWriter.WriteLine(documentData[i]);
                    }
                    streamWriter.Close();
                }

            }
        }

        private void userConfigDelete(object idObtaine)
        {
            string line;
            List<string> documentData = new List<string>();

            if (File.Exists(Program.path))
            {
                using (StreamReader sr = new StreamReader(Program.path))
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
                using (StreamWriter streamWriter = new StreamWriter(Program.path))
                {
                    for (int i = 0; i < documentData.Count; i++)
                    {
                        streamWriter.WriteLine(documentData[i]);
                    }
                    streamWriter.Close();
                }

            }
        }

        private void userConfig(object idObtaine, int _case, object newValue)
        {
            string line;
            List<string> documentData = new List<string>();

            if (File.Exists(Program.path))
            {
                using (StreamReader sr = new StreamReader(Program.path))
                {
                    while ((line = sr.ReadLine()) != null) 
                    {
                        documentData.Add(line);
                    }
                }
                for (int i = 0; i < documentData.Count;i++) 
                {
                    if (documentData[i].Contains(idObtaine.ToString())) 
                    {
                        string[] lineEdit = documentData[i].Split(',');
                        
                        lineEdit[_case] = newValue.ToString();
                        documentData[i] = string.Join(",", lineEdit);
                        break;
                    }
                }
                using (StreamWriter streamWriter = new StreamWriter(Program.path))
                {
                    for (int i = 0; i < documentData.Count; i++) 
                    {
                        streamWriter.WriteLine(documentData[i]);
                    }
                    streamWriter.Close();
                }

            }
        }

        private void dgvUsersData_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            try 
            {
                object newValue = dgvUsersData.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                object idObtaine = dgvUsersData.Rows[e.RowIndex].Cells[0].Value;
                int _case;

                if (File.Exists(Program.path))
                {
                    switch (e.ColumnIndex) 
                    {
                        case 1:
                            _case = 1;
                            userConfig(idObtaine,_case,newValue);
                            break;
                        case 2:
                            _case = 2;
                            userConfig(idObtaine, _case, newValue);
                            break;
                        case 3:
                            _case = 3;
                            userConfig(idObtaine, _case, newValue);
                            break;
                        case 4:
                            _case = 4;
                            userConfig(idObtaine, _case, newValue);
                            break;

                    }
                    
                }

            }

            catch 
            {
                
            }
            

        }
        private void btnUserCreator_Click(object sender, EventArgs e)
        {

            if (cbBoxRolOptions.SelectedItem == null)
            {

            }

            else 
            {
                try
                {
                    string userName = txtBoxUserNameCreator.Text;
                    string password = txtBoxPasswordCreator.Text;
                    string rol = cbBoxRolOptions.SelectedItem.ToString();
                    string branch = cbBoxBranch.SelectedItem.ToString();
                    string Line;
                    int id = File.ReadLines(Program.path).Count() - 1;

                    if (File.Exists(Program.path))
                    {
                        using (StreamReader sr = new StreamReader(Program.path))
                        {
                            while ((Line = sr.ReadLine()) != null)
                            {
                                if (Line.Contains(userName))
                                {
                                    string[] lineEdit = Line.Split(',');
                                    if (lineEdit[1] == userName) { return; }
                                }

                            }
                        }
                        using (StreamWriter streamWriter = new StreamWriter(Program.path, true))
                        {
                            streamWriter.WriteLine(string.Join(",", $"_{id + 1}", userName, password, rol,branch));
                            userBindingSource.Add(new User($"_{(id + 1).ToString()}", userName, password, rol,branch));
                            dgvUsersData.Refresh();
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("Error en btnUserCreator_Click");
                }
            }
        }


        private void Users_Load(object sender, EventArgs e)
        {

            if (File.Exists(Program.path))
            {

                userConfigLoad();
               
            }
        }

        private void dgvUsersData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUsersData.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                object idObtaine = dgvUsersData.Rows[e.RowIndex].Cells[0].Value;

                Console.WriteLine(idObtaine);

                if (File.Exists(Program.path))
                {
                    userConfigDelete(idObtaine);
                    while (dgvUsersData.Rows.Count > 0)
                    {
                        dgvUsersData.Rows.RemoveAt(dgvUsersData.Rows.Count - 1);
                    }
                    userConfigLoad();
                }

            }
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inventario inventario = new Inventario();
            inventario.Show();
        }
    }
}
