using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Tienda_Escritorio
{
    public partial class ClienteForm : Form
    {
        private decimal total = 0;

        public ClienteForm()
        {
            InitializeComponent();
        }

        private void ClienteForm_Load(object sender, EventArgs e)
        {
            LoadProductos();
        }

        private void LoadProductos()
        {
            string query = "SELECT ProductoID, Nombre, Precio, Categoria FROM Productos";
            using (SQLiteDataReader reader = Data_Bases.ExecuteReader(query))
            {
                if (reader != null)
                {
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    dataGridViewProductos.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("No hay Productos Cargados.");
                }
            }
        }

        private void btnAgregarAlCarrito_Click(object sender, EventArgs e)
        {
            if (dataGridViewProductos.SelectedRows.Count > 0)
            {
                string nombreProducto = dataGridViewProductos.SelectedRows[0].Cells["Nombre"].Value.ToString();
                decimal precioProducto = decimal.Parse(dataGridViewProductos.SelectedRows[0].Cells["Precio"].Value.ToString());

                listBoxCarrito.Items.Add($"{nombreProducto} - ${precioProducto}");
                total += precioProducto;
                labelTotal.Text = $"Total: ${total}";
            }
            else
            {
                MessageBox.Show("seleccione un producto para agregar al carrito.");
            }
        }

        private void btnFinalizarCompra_Click(object sender, EventArgs e)
        {
            if (listBoxCarrito.Items.Count > 0)
            {
                string query = "INSERT INTO Ventas (Fecha, Total) VALUES (@Fecha, @Total)";
                SQLiteParameter[] parameters = new SQLiteParameter[]
                {
                    new SQLiteParameter("@Fecha", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")),
                    new SQLiteParameter("@Total", total)
                };

                int ventaID = Data_Bases.ExecuteNonQuery(query, parameters);

                if (ventaID > 0)
                {
                    foreach (string item in listBoxCarrito.Items)
                    {
                        string nombreProducto = item.Split('-')[0].Trim();
                        decimal precioProducto = decimal.Parse(item.Split('$')[1].Trim());

                        string queryDetalle = "INSERT INTO DetallesVenta (VentaID, ProductoID, PrecioUnitario) VALUES (@VentaID, @ProductoID, @PrecioUnitario)";
                        SQLiteParameter[] parametersDetalle = new SQLiteParameter[]
                        {
                            new SQLiteParameter("@VentaID", ventaID),
                            new SQLiteParameter("@ProductoID", ObtenerProductoID(nombreProducto)),
                            new SQLiteParameter("@PrecioUnitario", precioProducto)
                        };

                        Data_Bases.ExecuteNonQuery(queryDetalle, parametersDetalle);
                    }

                    MessageBox.Show("Compra finalizada. Gracias por su compra.");
                    listBoxCarrito.Items.Clear();
                    total = 0;
                    labelTotal.Text = "Total: $0";
                }
                else
                {
                    MessageBox.Show("Error al finalizar la compra.");
                }
            }
            else
            {
                MessageBox.Show("El carrito está vacío. Agregue productos antes de finalizar la compra.");
            }
        }

        private int ObtenerProductoID(string nombreProducto)
        {
            string query = "SELECT ProductoID FROM Productos WHERE Nombre = @Nombre";
            SQLiteParameter[] parameters = new SQLiteParameter[]
            {
                new SQLiteParameter("@Nombre", nombreProducto)
            };

            using (SQLiteDataReader reader = Data_Bases.ExecuteReader(query, parameters))
            {
                if (reader != null && reader.Read())
                {
                    return reader.GetInt32(0);
                }
            }

            return -1;
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Form1.Instance.Show();
            this.Close();
        }

        private void dataGridViewProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Btn_Regresar_Click(object sender, EventArgs e)
        {
            Form1.Instance.Show();
            this.Close();
        }

        private void Btn_Actualizar_Click(object sender, EventArgs e)
        {
            LoadProductos();
        }
    }
}