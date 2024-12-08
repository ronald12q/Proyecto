using System;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace Tienda_Escritorio
{
    public static class Data_Bases
    {
        private static string databasePath = Path.Combine(Application.StartupPath, "TiendaDB3.sqlite");
        private static string connectionString = $"Data Source={databasePath};Version=3;";

        public static SQLiteConnection GetConnection()
        {
            if (!File.Exists(databasePath))
            {
                CreateDatabase();
            }
            return new SQLiteConnection(connectionString);
        }

        private static void CreateDatabase()
        {
            try
            {
                SQLiteConnection.CreateFile(databasePath);
                using (SQLiteConnection connection = GetConnection())
                {
                    connection.Open();
                    string query = @"
                        CREATE TABLE Usuarios (
                            UsuarioID INTEGER PRIMARY KEY AUTOINCREMENT,
                            Nombre TEXT NOT NULL,
                            Contraseña TEXT NOT NULL
                        );

                        CREATE TABLE Productos (
                            ProductoID INTEGER PRIMARY KEY AUTOINCREMENT,
                            Nombre TEXT NOT NULL,
                            Precio REAL NOT NULL,
                            Categoria TEXT NOT NULL
                        );

                        CREATE TABLE Ventas (
                            VentaID INTEGER PRIMARY KEY AUTOINCREMENT,
                            Fecha TEXT NOT NULL,
                            Total REAL NOT NULL
                        );

                        CREATE TABLE DetallesVenta (
                            DetalleID INTEGER PRIMARY KEY AUTOINCREMENT,
                            VentaID INTEGER NOT NULL,
                            ProductoID INTEGER NOT NULL,
                            PrecioUnitario REAL NOT NULL,
                            FOREIGN KEY (VentaID) REFERENCES Ventas(VentaID),
                            FOREIGN KEY (ProductoID) REFERENCES Productos(ProductoID)
                        );
                    ";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear la base de datos: {ex.Message}");
            }
        }

        public static int ExecuteNonQuery(string query, SQLiteParameter[] parameters = null)
        {
            try
            {
                using (SQLiteConnection connection = GetConnection())
                {
                    connection.Open();
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        if (parameters != null)
                        {
                            command.Parameters.AddRange(parameters);
                        }
                        return command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al ejecutar la consulta: {ex.Message}");
                return -1;
            }
        }

        public static SQLiteDataReader ExecuteReader(string query, SQLiteParameter[] parameters = null)
        {
            try
            {
                SQLiteConnection connection = GetConnection();
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }
                    return command.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al ejecutar la consulta: {ex.Message}");
                return null;
            }
        }
    }
}

//base de datos, metodos, conexiones.