using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Tienda_Escritorio
{
    public partial class AgregarProductoForm : Form
    {
        public AgregarProductoForm()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            decimal precio = decimal.Parse(txtPrecio.Text);
            string categoria = txtCategoria.Text;

            string query = "INSERT INTO Productos (Nombre, Precio, Categoria) VALUES (@Nombre, @Precio, @Categoria)";
            SQLiteParameter[] parameters = new SQLiteParameter[]
            {
                new SQLiteParameter("@Nombre", nombre),
                new SQLiteParameter("@Precio", precio),
                new SQLiteParameter("@Categoria", categoria)
            };

            int rowsAffected = Data_Bases.ExecuteNonQuery(query, parameters);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Producto agregado Exitosamente.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al agregar el producto, verifica la base de datos.");
            }
        }
    }
}