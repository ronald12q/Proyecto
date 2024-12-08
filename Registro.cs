using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Tienda_Escritorio
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Form1.Instance.Show();
            this.Hide(); 
        }

        private void BtnRegistro_EnRegistro_Click(object sender, EventArgs e)
        {
            string nombre = TxtNombre_RE.Text;
            string contraseña = TxtContraseña_Re.Text;

            string query = "INSERT INTO Usuarios (Nombre, Contraseña) VALUES (@Nombre, @Contraseña)";
            SQLiteParameter[] parameters = new SQLiteParameter[]
            {
                new SQLiteParameter("@Nombre", nombre),
                new SQLiteParameter("@Contraseña", contraseña)
            };

            int rowsAffected = Data_Bases.ExecuteNonQuery(query, parameters);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Registro exitoso.");
                Form1.Instance.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al registrar.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TxtContraseña_Re.UseSystemPasswordChar == true)
            {
                TxtContraseña_Re.UseSystemPasswordChar = false;
            }
            else if (TxtContraseña_Re.UseSystemPasswordChar != true)
            {
                TxtContraseña_Re.UseSystemPasswordChar = true;
            }
        }
    }
}