using SingIn;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Taller_2.Displays
{
    public partial class Statistics : Form
    {
        public Statistics()
        {
            InitializeComponent();
        }

        



        private void chartProductos_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            List<string> branchList = new List<string>() {"Sucursal 1","Sucursal 2","Sucursal 3"};
            List<int> branchStockList = new List<int>() {0,0,0};
            List<string> documentData = new List<string>();
            string line;

            if (File.Exists(Program.productPath)) 
            {
                using (StreamReader sr = new StreamReader(Program.productPath)) 
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        documentData.Add(line);
                    }

                    for (int i = 0; i < documentData.Count; i++) 
                    {
                        string[] lineEdit = documentData[i].Split(',');
                        if (lineEdit[3] == "Sucursal 1")
                        {
                            branchStockList[0] = branchStockList[0] + int.Parse(lineEdit[4]);
                        }
                        else if (lineEdit[3] == "Sucursal 2")
                        {
                            branchStockList[1] = branchStockList[0] + int.Parse(lineEdit[4]);
                        }
                        else if (lineEdit[3] == "Sucursal 3")
                        {
                            branchStockList[2] = branchStockList[0] + int.Parse(lineEdit[4]);
                        }
                    }
                }
            }



            chartProductos.Series.Clear();
            chartProductos.Titles.Add("Cantidad de productos por sucursal");

            Console.WriteLine(branchStockList.Count);

            for (int i = 0; i < branchList.Count; i++) 
            {
                Series series = chartProductos.Series.Add(branchList[i]);

                series.Label = branchStockList[i].ToString();

                series.Points.Add(branchStockList[i]);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inventario inventario = new Inventario();   
            inventario.Show();
        }
    }
}
