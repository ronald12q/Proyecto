using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Tienda_Escritorio
{
    public partial class EditarProductoForm : Form
    {
        public EditarProductoForm()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombreProducto = txtnombre.Text;
            decimal nuevoPrecio = decimal.Parse(txtprecio.Text);
            string nuevaCategoria = txtcategoria.Text;

            string query = "UPDATE Productos SET Precio = @NuevoPrecio, Categoria = @NuevaCategoria WHERE Nombre = @Nombre";
            SQLiteParameter[] parameters = new SQLiteParameter[]
            {
                new SQLiteParameter("@NuevoPrecio", nuevoPrecio),
                new SQLiteParameter("@NuevaCategoria", nuevaCategoria),
                new SQLiteParameter("@Nombre", nombreProducto)
            };

            int rowsAffected = Data_Bases.ExecuteNonQuery(query, parameters);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Producto actualizado.");
                this.Close();
            }
            else
            {
                MessageBox.Show("No se encontró un producto con ese nombre.");
            }
        }
    }
}