using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Tienda_Escritorio
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
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
                    MessageBox.Show("No se encontraron productos.");
                }
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            AgregarProductoForm agregarProductoForm = new AgregarProductoForm();
            agregarProductoForm.ShowDialog();
            LoadProductos();
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            EliminarForm eliminarProductoForm = new EliminarForm();
            eliminarProductoForm.ShowDialog();
            LoadProductos();
        }

        private void btnEditarProducto_Click(object sender, EventArgs e)
        {
            EditarProductoForm editarProductoForm = new EditarProductoForm();
            editarProductoForm.ShowDialog();
            LoadProductos();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Form1.Instance.Show();
            this.Close();
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

        private void dataGridViewProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}