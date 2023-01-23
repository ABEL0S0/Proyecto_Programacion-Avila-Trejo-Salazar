using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Programacion_Avila_Trejo_Salazar.DAO
{
    internal class UsuariosDao
    {
        private string cadenadeconexion = @"Server = ROBERSON1; database=Project; integrated security=true";//Poner el nombre del servidor y su seguridad
        
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

        /// <summary>
        /// Funcion que inicia sesion al recuperar los datos de la base de datos
        /// </summary>
        /// <param name="Usuario"></param>
        /// <param name="Contrasenia"></param>
        /// <returns></returns>
        public DataTable InicioSesion(string Usuario, string Contrasenia)
        {
            //Creo la conexion con el motor de base de datos
            SqlConnection connection = new SqlConnection(cadenadeconexion);

            //Creo el comando que busca el registro
            string sql = "select Nombres, Apellidos, Usuario, Contrasenia "
                + "from Project where Usuario=@Usuario, Contrasenia=@Contrasenia";

            //Declaro un objeto tipo data Table
            DataTable dt = new DataTable();

            //Declaro un adaptador de datos
            SqlDataAdapter ad = new SqlDataAdapter(sql, connection);

            //Agrego el parametro matricula
            ad.SelectCommand.Parameters.Add(new SqlParameter("@Usuario", Usuario));
            ad.SelectCommand.Parameters.Add(new SqlParameter("@Contrasenia", Contrasenia));

            //Lleno el datatable dt
            ad.Fill(dt);

            //retorno el datatable dt
            return dt;
        }
    }
}
