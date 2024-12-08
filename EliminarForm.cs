using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tienda_Escritorio
{
    public partial class EliminarForm : Form
    {
        public EliminarForm()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string nombreProducto = txtNombreProducto.Text;

            string query = "DELETE FROM Productos WHERE Nombre = @Nombre";
            SQLiteParameter[] parameters = new SQLiteParameter[]
            {
                new SQLiteParameter("@Nombre", nombreProducto)
            };

            int rowsAffected = Data_Bases.ExecuteNonQuery(query, parameters);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Producto eliminado.");
                this.Close();
            }
            else
            {
                MessageBox.Show("No se encontró un producto con ese nombre.");
            }

        }

        private void txtNombreProducto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
