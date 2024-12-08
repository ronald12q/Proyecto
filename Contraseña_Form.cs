using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Tienda_Escritorio
{
    public partial class Contraseña_Form : Form
    {
        public Contraseña_Form()
        {
            InitializeComponent();
        }

        private void Btn_Regresar_Click(object sender, EventArgs e)
        {

            Form1.Instance.Show();
            this.Close();
        }



        private void Btn_Restablecer_Click_1(object sender, EventArgs e)
        {
            string nombre = TxtNombre.Text;
            string nuevaContraseña = TxtContraseña.Text;

            string query = "UPDATE Usuarios SET Contraseña = @Contraseña WHERE Nombre = @Nombre";
            SQLiteParameter[] parameters = new SQLiteParameter[]
            {
                new SQLiteParameter("@Contraseña", nuevaContraseña),
                new SQLiteParameter("@Nombre", nombre)
            };

            int rowsAffected = Data_Bases.ExecuteNonQuery(query, parameters);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Contraseña restablecida.");
                Form1.Instance.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al restablecer la contraseña.");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TxtContraseña.UseSystemPasswordChar == true)
            {
                TxtContraseña.UseSystemPasswordChar = false;
            }
            else if (TxtContraseña.UseSystemPasswordChar != true) { 
            TxtContraseña.UseSystemPasswordChar= true;
            }
            
        }
    }
}