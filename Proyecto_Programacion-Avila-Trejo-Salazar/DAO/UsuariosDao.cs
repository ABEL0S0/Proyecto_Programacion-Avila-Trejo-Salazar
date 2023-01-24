using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Programacion_Avila_Trejo_Salazar.DAO
{
    internal class UsuariosDao
    {
        private string cadenadeconexion = @"Server = ROBERSON1; database=Project; integrated security=true";//Poner el nombre del servidor y su seguridad
        protected string mensaje;

        /// <summary>
        /// Registrar Usuario en base de datos
        /// </summary>
        /// <param name="usuarios"></param>
        /// <returns></returns>
        public int Registrar(Usuarios usuarios)
        {
            //Creo la conexion con el motor de base de datos
            SqlConnection connection = new SqlConnection(cadenadeconexion);

            //Creo el comando que guarda los registros en la BDD
            string sql = "insert into Usuarios(Nombres, Apellidos, Usuario, Contrasenia) " +
                "values(@Nombres, @Apellidos, @Usuario, @Contrasenia)";
            SqlCommand comando = new SqlCommand(sql, connection);

            //Abro conexion
            connection.Open();

            //Agrego los parametros 
            comando.Parameters.Add(new SqlParameter("@Nombres", usuarios.Nombres));
            comando.Parameters.Add(new SqlParameter("@Apellidos", usuarios.Apellidos));
            comando.Parameters.Add(new SqlParameter("@Usuario", usuarios.Usuario));                      
            comando.Parameters.Add(new SqlParameter("@Contrasenia", usuarios.Contrasenia));

            //Ejecuto el comando (guardar el registro en la BDD)
            int resultado = comando.ExecuteNonQuery();

            //Cerrar la conexion
            connection.Close();

            return resultado;
        }

        public string Mensaje
        {
            get
            {
                return this.mensaje;
            }
        }

        /// <summary>
        /// Funcion que inicia sesion al recuperar los datos de la base de datos
        /// </summary>
        /// <param name="Usuario"></param>
        /// <param name="Contrasenia"></param>
        /// <returns></returns>
        public bool InicioSesion(string Usuario, string Contrasenia)
        {
            
           bool Resultado = false;

           //Creo la conexion con el motor de base de datos
           SqlConnection connection = new SqlConnection(cadenadeconexion);
           //Creo el comando que busca el registro
           string sql = string.Format(@"select Nombres, Apellidos, Usuario, Contrasenia "
                    + "from Usuarios where Usuario='{0}' and Contrasenia='{1}'", Usuario, Contrasenia);
           SqlCommand comando = new SqlCommand(sql, connection);
           connection.Open();
           SqlDataReader Reg = null;
           Reg = comando.ExecuteReader();
           if (Reg.Read())
           {
                Resultado = true;
                connection.Close();
                return Resultado;
           }
           else
           {
                Resultado = false;
                connection.Open();
           }
           connection.Close();
           return Resultado;
            
        }
    }
}
