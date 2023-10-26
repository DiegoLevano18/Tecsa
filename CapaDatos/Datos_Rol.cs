using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Datos_Rol
    {
        SqlConnection cn = new SqlConnection(
            ConfigurationManager.ConnectionStrings["cn"].ConnectionString);

        public DataTable Vista_Rol()
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_Ver_Rol", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public string Crear_Rol(Rol oRol)
        {
            // Abrir Conexión 
            cn.Open();

            // Definir SP a Ejecutar: En este ejemplo es sp_CrearCliente
            SqlCommand cmd = new SqlCommand("sp_Crear_Rol", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            // Asignado valores a los parámetros de entrada
            // Los valores se obtendrán de un objeto de la Entidad Cliente
            cmd.Parameters.AddWithValue("@nombre", oRol.Nombre);

            // Configurando el parámetro de entrada del sp_CrearCliente
            SqlParameter param = new SqlParameter("@resultado", SqlDbType.VarChar, 50);
            param.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(param);

            // Ejecutando el procedimiento almacenado
            cmd.ExecuteNonQuery();

            // Cerrando la conexión
            cn.Close();

            // El método NuevoCliente devolverá el valor del parámetro de salida de sp
            // @resultado en el parámetro de salida del sp_CrearCliente
            return cmd.Parameters["@resultado"].Value.ToString();

        }

        public DataTable Buscar_Rol(int Id)
        {

            cn.Open();
            SqlCommand cmd = new SqlCommand("sp_Buscar_Rol", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", Id);
            cn.Close();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;

        }


        public string Actualizar_Rol(Rol oRol)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("sp_Actualizar_Rol", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", oRol.Id);
            cmd.Parameters.AddWithValue("@nombre", oRol.Nombre);

            // El nombre del parámetro de salida del sp es @resultado
            SqlParameter param = new SqlParameter("@resultado", SqlDbType.VarChar, 50);
            param.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(param);

            cmd.ExecuteNonQuery();
            cn.Close();

            //Devuelve el valor del parámetro de salida @resultado
            return cmd.Parameters["@resultado"].Value.ToString();
        }

        public int Eliminar_Rol(int Id)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("sp_Eliminar_Rol", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", Id);

            // Si el procedimiento almacenado devuelve un mensaje de confirmación
            SqlParameter param = new SqlParameter("@resultado", SqlDbType.Int);
            param.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(param);

            // Ejecutar el procedimiento almacenado
            cmd.ExecuteNonQuery();
            cn.Close();

            // Capturar el mensaje de confirmación o el resultado de la eliminación
            return (int)cmd.Parameters["@resultado"].Value;
        }

    }
}
