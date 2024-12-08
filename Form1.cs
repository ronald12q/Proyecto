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
            if (TxtContrase�a.UseSystemPasswordChar == true)
            {
                TxtContrase�a.UseSystemPasswordChar = false;
            }
            else if (TxtContrase�a.UseSystemPasswordChar == false)
            {
                TxtContrase�a.UseSystemPasswordChar = true;
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
            string contrase�a = TxtContrase�a.Text;

            // admin datos
            if (nombre == "admin" && contrase�a == "admin123")
            {
                AdminForm adminForm = new AdminForm();
                adminForm.Show();
                this.Hide();
                return;
            }

            
            string query = "SELECT UsuarioID FROM Usuarios WHERE Nombre = @Nombre AND Contrase�a = @Contrase�a";
            SQLiteParameter[] parameters = new SQLiteParameter[]
            {
                new SQLiteParameter("@Nombre", nombre),
                new SQLiteParameter("@Contrase�a", contrase�a)
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
                    MessageBox.Show("Nombre de usuario o contrase�a incorrectos.");
                }
            }
        }

        private void BtnOlvide_Contrase�a_Click(object sender, EventArgs e)
        {
            Contrase�a_Form contrase�a_Form = new Contrase�a_Form();
            contrase�a_Form.Show();
            this.Hide();
        }
    }
}