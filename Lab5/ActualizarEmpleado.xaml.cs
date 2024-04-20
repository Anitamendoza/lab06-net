using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace Lab5
{
    public partial class ActualizarEmpleado : Window
    {
        // Propiedades para el enlace de datos
        public int IdEmpleado { get; set; }
        public string Apellidos { get; set; }
        public string Nombre { get; set; }
        public string Cargo { get; set; }
        public string Tratamiento { get; set; }
        public string FechaNacimiento { get; set; }
        public string FechaContratacion { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public string Region { get; set; }
        public string CodPostal { get; set; }
        public string Pais { get; set; }
        public string TelDomicilio { get; set; }
        public string Extension { get; set; }
        public string Notas { get; set; }
        public int Jefe { get; set; }
        public double SueldoBasico { get; set; }
        private int idempleado { get; set; }

        // Cadena de conexión a la base de datos
        private string connectionString = "Data Source=LAB1504-02\\SQLEXPRESS;Initial Catalog=Neptunodb;User Id=mendoza;Password=123456";

        public ActualizarEmpleado(int idempleado)
        {
            InitializeComponent();
            DataContext = this;
            CargarDatosEmpleado(idempleado);

        }

        public void CargarDatosEmpleado(int idEmpleado)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("USP_CargarDatosEmpleado", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@IdEmpleado", idEmpleado);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        IdEmpleado = Convert.ToInt32(reader["IdEmpleado"]);
                        Apellidos = reader["Apellidos"].ToString();
                        Nombre = reader["Nombre"].ToString();
                        Cargo = reader["Cargo"].ToString();
                        Tratamiento = reader["Tratamiento"].ToString();
                        FechaNacimiento = reader["FechaNacimiento"].ToString();
                        FechaContratacion = reader["FechaContratacion"].ToString();
                        Direccion = reader["Direccion"].ToString();
                        Ciudad = reader["Ciudad"].ToString();
                        Region = reader["Region"].ToString();
                        CodPostal = reader["CodPostal"].ToString();
                        Pais = reader["Pais"].ToString();
                        TelDomicilio = reader["TelDomicilio"].ToString();
                        Extension = reader["Extension"].ToString();
                        Notas = reader["Notas"].ToString();
                        Jefe = Convert.ToInt32(reader["Jefe"]);
                        SueldoBasico = Convert.ToDouble(reader["SueldoBasico"]);
                    }

                    reader.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al cargar datos del empleado: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error general: " + ex.Message);
            }
        }

        private void Actualizar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("USP_Actualizar_Empleado", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@IdEmpleado", IdEmpleado);
                    command.Parameters.AddWithValue("@Apellidos", Apellidos);
                    command.Parameters.AddWithValue("@Nombre", Nombre);
                    command.Parameters.AddWithValue("@Cargo", Cargo);
                    command.Parameters.AddWithValue("@Tratamiento", Tratamiento);
                    command.Parameters.AddWithValue("@FechaNacimiento", FechaNacimiento);
                    command.Parameters.AddWithValue("@FechaContratacion", FechaContratacion);
                    command.Parameters.AddWithValue("@Direccion", Direccion);
                    command.Parameters.AddWithValue("@Ciudad", Ciudad);
                    command.Parameters.AddWithValue("@Region", Region);
                    command.Parameters.AddWithValue("@CodPostal", CodPostal);
                    command.Parameters.AddWithValue("@Pais", Pais);
                    command.Parameters.AddWithValue("@TelDomicilio", TelDomicilio);
                    command.Parameters.AddWithValue("@Extension", Extension);
                    command.Parameters.AddWithValue("@Notas", Notas);
                    command.Parameters.AddWithValue("@Jefe", Jefe);
                    command.Parameters.AddWithValue("@SueldoBasico", SueldoBasico);

                    command.ExecuteNonQuery();

                    MessageBox.Show("Empleado actualizado correctamente.");

                    ListarEmpleados listarEmpleados = new ListarEmpleados();
                    listarEmpleados.Show();
                    this.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al actualizar empleado: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error general: " + ex.Message);
            }
        }

        private void Guardar_Click_listar(object sender, RoutedEventArgs e)
        {
            ListarEmpleados listarEmpleados = new ListarEmpleados();
            listarEmpleados.Show();
            this.Close();
        }

    }
}
