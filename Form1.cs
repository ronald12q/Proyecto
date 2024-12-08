using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Tienda_Escritorio
{
    public partial class Form1 : Form
    {
        private static Form1 instance;

        public static Form1 Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new Form1();
                }
                return instance;
            }
        }

        private Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (TxtContraseña.UseSystemPasswordChar == true)
            {
                TxtContraseña.UseSystemPasswordChar = false;
            }
            else if (TxtContraseña.UseSystemPasswordChar == false)
            {
                TxtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void BtnRegistro_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro();
            this.Hide();
            registro.ShowDialog();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string nombre = TxtUsuario.Text;
            string contraseña = TxtContraseña.Text;

            // admin datos
            if (nombre == "admin" && contraseña == "admin123")
            {
                AdminForm adminForm = new AdminForm();
                adminForm.Show();
                this.Hide();
                return;
            }

            
            string query = "SELECT UsuarioID FROM Usuarios WHERE Nombre = @Nombre AND Contraseña = @Contraseña";
            SQLiteParameter[] parameters = new SQLiteParameter[]
            {
                new SQLiteParameter("@Nombre", nombre),
                new SQLiteParameter("@Contraseña", contraseña)
            };

            using (SQLiteDataReader reader = Data_Bases.ExecuteReader(query, parameters))
            {
                if (reader != null && reader.Read())
                {
                    ClienteForm clienteForm = new ClienteForm();
                    clienteForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Nombre de usuario o contraseña incorrectos.");
                }
            }
        }

        private void BtnOlvide_Contraseña_Click(object sender, EventArgs e)
        {
            Contraseña_Form contraseña_Form = new Contraseña_Form();
            contraseña_Form.Show();
            this.Hide();
        }
    }
}