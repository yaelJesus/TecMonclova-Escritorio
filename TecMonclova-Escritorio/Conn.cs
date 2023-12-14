using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TecMonclova_Escritorio
{
    class Conn
    {
        public static SqlConnection conexion = new SqlConnection();

        static string servidor = "localhost";
        static string bd = "SchoolServicesYael";
        static string ususario = "sa";
        static string password = "123456";

        static String cadenaConexion = "server=" + servidor + ";" + "user id =" + ususario + ";" + "password=" + password + ";" + "database=" + bd + ";";

        private static void conectar()
        {
            try
            {
                conexion.ConnectionString = cadenaConexion;
                conexion.Open();
                //MessageBox.Show("Se conecto correctamente la base de datos");
            }
            catch (SqlException e)
            {
                MessageBox.Show("No se puede conectar a la base de datos de SQLServer, error:" + e.ToString());
            }
        }

        public static DataTable ejecutaConsultaSelect(string consulta)
        {
            conectar();
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataSet ds = new DataSet();
            adaptador.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

        public static void ejecutaConsulta(string consulta)
        {
            conectar();
            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public static bool ejecutaConsultaLogin(string user, string pass)
        {
            conectar();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandText = "select * from [User] where (userName = @user and password = @pass) or (email = @user and password = @pass)";
            comando.Parameters.AddWithValue("@user", user);
            comando.Parameters.AddWithValue("@pass", pass);
            comando.CommandType = CommandType.Text;
            SqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    UserCache.IdUser = reader.GetInt32(0);
                    UserCache.UserName = reader.GetString(1);
                    UserCache.Name = reader.GetString(2);
                    UserCache.Password = reader.GetString(3);
                    UserCache.Email = reader.GetString(4);
                }
                conexion.Close();
                return true;
            }
            else
                conexion.Close(); return false;
        }

        internal static string GetConnectionString()
        {
            //throw new NotImplementedException();
            return cadenaConexion;
        }
    }
}
