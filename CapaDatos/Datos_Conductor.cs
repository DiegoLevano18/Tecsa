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
    public class Datos_Conductor
    {
        SqlConnection cn = new SqlConnection(
            ConfigurationManager.ConnectionStrings["cn"].ConnectionString);

        public DataTable Vista_Conductor()
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_Ver_Conductor", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public string Crear_Conductor(Conductor oConductor)
        {

            // Abrir Conexión 
            cn.Open();

            // Definir SP a Ejecutar: En este ejemplo es sp_CrearCliente
            SqlCommand cmd = new SqlCommand("sp_Crear_Conductor", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            // Asignado valores a los parámetros de entrada
            // Los valores se obtendrán de un objeto de la Entidad Cliente
            cmd.Parameters.AddWithValue("@idlicencia", oConductor.IdLicencia);
            cmd.Parameters.AddWithValue("@nombre", oConductor.Nombre);
            cmd.Parameters.AddWithValue("@apellido", oConductor.Apellido);
            cmd.Parameters.AddWithValue("@edad", oConductor.Edad);
            cmd.Parameters.AddWithValue("@correo", oConductor.Correo);
            cmd.Parameters.AddWithValue("@telefono", oConductor.Telefono);
            cmd.Parameters.AddWithValue("@estado", oConductor.Estado);
            cmd.Parameters.AddWithValue("@dni", oConductor.DNI);

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

        public DataTable Buscar_Conductor(int Id)
        {

            cn.Open();
            SqlCommand cmd = new SqlCommand("sp_Buscar_Conductor", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", Id);
            cn.Close();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;

        }


        public string Actualizar_Conductor(Conductor oConductor)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("sp_Actualizar_Conductor", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", oConductor.Id);
            cmd.Parameters.AddWithValue("@idlicencia", oConductor.IdLicencia);
            cmd.Parameters.AddWithValue("@nombre", oConductor.Nombre);
            cmd.Parameters.AddWithValue("@apellido", oConductor.Apellido);
            cmd.Parameters.AddWithValue("@edad", oConductor.Edad);
            cmd.Parameters.AddWithValue("@correo", oConductor.Correo);
            cmd.Parameters.AddWithValue("@telefono", oConductor.Telefono);
            cmd.Parameters.AddWithValue("@estado", oConductor.Estado);
            cmd.Parameters.AddWithValue("@dni", oConductor.DNI);

            // El nombre del parámetro de salida del sp es @resultado
            SqlParameter param = new SqlParameter("@resultado", SqlDbType.VarChar, 50);
            param.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(param);

            cmd.ExecuteNonQuery();
            cn.Close();

            //Devuelve el valor del parámetro de salida @resultado
            return cmd.Parameters["@resultado"].Value.ToString();
        }

        public int Eliminar_Conductor(int Id)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("sp_Eliminar_Conductor", cn);
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
