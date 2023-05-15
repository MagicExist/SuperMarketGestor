using ProductClass;
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
using Taller_2;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace facturacion
{
    public partial class FacturacionVendedores : Form
    {

        public static List<string> Products = new List<string>();
        public static List<string> Stocks = new List<string>();
        public static List<string> Price = new List<string>();
        public static List<string> ProductsFactura = new List<string>();
        public static List<string> StocksFactura = new List<string>();
        public static List<string> PriceFactura = new List<string>();
        public FacturacionVendedores()
        {
            InitializeComponent();
        }

        private void FacturacionVendedores_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void productVendedoresConfigLoad()
        {
            cbBoxProductos.Items.Clear();
            cbBoxProductos.SelectedItem = "";
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
                        
                        cbBoxProductos.Items.Add(lineEdit[1]);
                        Products.Add(lineEdit[1]);
                        Price.Add(lineEdit[2]);
                        Stocks.Add(lineEdit[4]);
                        
                    }

                }
                cbBoxProductos.Refresh();
                this.Refresh();
            }
        }

        private void FacturacionVendedores_Load(object sender, EventArgs e)
        {
            productVendedoresConfigLoad();
        }

        private void cbBoxProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < Stocks.Count; i++)
            {
                if (cbBoxProductos.SelectedIndex == i)
                {
                    txtBoxUnitario.Text = $"${Price[i]}";
                    txtBoxStock.Text = Stocks[i];
                }
            }

        }

        private void btnCanasta_Click(object sender, EventArgs e)
        {

            bool crear = false;

            for (int i = 0; i < Stocks.Count; i++)
            {
                if (cbBoxProductos.SelectedIndex == i)
                {
                    if (int.Parse(txtBoxStock.Text) > int.Parse(Stocks[i]) || int.Parse(txtBoxStock.Text) <= 0)
                    {

                    }
                    else
                    {
                        foreach (DataGridViewRow row in dgvFacturacion.Rows)
                        {

                            if (row != null && row.Cells[0].Value != null && cbBoxProductos != null && cbBoxProductos.SelectedIndex >= 0 && row.Cells[0].Value.ToString() == cbBoxProductos.Items[cbBoxProductos.SelectedIndex].ToString())
                            {
                                row.Cells[1].Value = (int.Parse(row.Cells[1].Value.ToString()) + int.Parse(Stocks[i])).ToString();
                                crear = true;

                                break;
                            }
                        }
                        if (crear == false)
                        {
                            productBindingSource.Add(new Product()
                            {
                                Name = cbBoxProductos.Items[cbBoxProductos.SelectedIndex].ToString(),
                                Price = int.Parse(Price[i]),
                                Stock = int.Parse(txtBoxStock.Text)

                            });
                        }
                        else { }
                        Stocks[i] = (int.Parse(Stocks[i]) - int.Parse(txtBoxStock.Text)).ToString();
                        crear = false;

                    }
                }
            }

        }

        private void dgvFacturacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvFacturacion.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                for (int i = 0; i < Stocks.Count; i++)
                {
                    if (Products[i] == dgvFacturacion.Rows[e.RowIndex].Cells[0].Value.ToString())
                    {
                        Stocks[i] = (int.Parse(Stocks[i]) + int.Parse(dgvFacturacion.Rows[e.RowIndex].Cells[1].Value.ToString())).ToString();
                    }
                }
                dgvFacturacion.Rows.RemoveAt(e.RowIndex);

            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            int stockDelete;
            string line;
            List<string> documentData = new List<string>();

            if (txtBoxUserName.Text != "" && txtBoxCity.Text != "" && txtBoxDirection.Text != "" && txtBoxEmail.Text != "" && txrBoxPhone.Text != "")
            {
                foreach (DataGridViewRow row in dgvFacturacion.Rows)
                {
                    if (row != null && row.Cells[0].Value != null && cbBoxProductos != null)
                    {
                        stockDelete = int.Parse(row.Cells[1].Value.ToString());

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
                                if (row.Cells[0].Value.ToString() == lineEdit[1])
                                {
                                    Console.WriteLine(row.Cells[0].Value.ToString());
                                    lineEdit[4] = (int.Parse(lineEdit[4]) - stockDelete).ToString();
                                    ProductsFactura.Add(lineEdit[1]);
                                    StocksFactura.Add(stockDelete.ToString());
                                    PriceFactura.Add(lineEdit[2]);
                                    break;
                                }

                                documentData[i] = string.Join(",", lineEdit);

                                if (lineEdit[4] == "0")
                                {
                                    documentData.RemoveAt(i);
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
                }
                dgvFacturacion.Rows.Clear();
                decimal subtotal = 0;
                using (StreamWriter streamWriter = new StreamWriter(Program.FacturacionPath))
                {
                    streamWriter.WriteLine("========================================");
                    streamWriter.WriteLine("             FACTURA DE VENTA            ");
                    streamWriter.WriteLine("========================================");

                    // Imprimir datos del usuario
                    streamWriter.WriteLine($"Nombre: {txtBoxUserName.Text}");
                    streamWriter.WriteLine($"Teléfono: {txrBoxPhone.Text}");
                    streamWriter.WriteLine($"Email: {txtBoxEmail.Text}");
                    streamWriter.WriteLine($"Ciudad: {txtBoxCity.Text}");
                    streamWriter.WriteLine($"Dirección: {txtBoxDirection.Text}");

                    // Imprimir detalle de la factura
                    streamWriter.WriteLine("\n========================================");
                    streamWriter.WriteLine("                DETALLE                 ");
                    streamWriter.WriteLine("========================================");
                    streamWriter.WriteLine("  Producto            Precio  Cantidad  ");
                    streamWriter.WriteLine("----------------------------------------");
                    Console.WriteLine(ProductsFactura.Count);
                    for (int i = 0; i < ProductsFactura.Count; i++)
                    {
                        streamWriter.WriteLine($"  {ProductsFactura[i]}            ${PriceFactura[i]}  {StocksFactura[i]}");
                    }
                    streamWriter.WriteLine("----------------------------------------");
                    for (int i = 0; i < StocksFactura.Count; i++)
                    {
                        subtotal = subtotal + int.Parse(PriceFactura[i]) * int.Parse(StocksFactura[i]);
                    }
                    // Calcular impuestos
                    decimal impuestos = subtotal * 0.16m;

                    // Calcular total
                    decimal total = subtotal + impuestos;

                    // Imprimir totales
                    streamWriter.WriteLine($"Subtotal: ${subtotal}");
                    streamWriter.WriteLine($"Impuestos: ${impuestos}");
                    streamWriter.WriteLine($"Total: ${total}");
                }
                ProductsFactura.Clear();
                PriceFactura.Clear();
                StocksFactura.Clear();
            }
            else 
            {
                MessageBox.Show("Error:Todos los campos deben de estar completos");
            }
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            this.Hide();
            InventarioVendedores inventarioVendedores = new InventarioVendedores();
            inventarioVendedores.Show();
        }
    }
}
