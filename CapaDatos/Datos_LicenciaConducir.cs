using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using CapaEntidad;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Datos_LicenciaConducir
    {
        SqlConnection cn = new SqlConnection(
            ConfigurationManager.ConnectionStrings["cn"].ConnectionString);

        public DataTable Vista_LicenciaConducir()
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_Ver_LicenciaConducir", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public string Crear_LicenciaConducir(LicenciaConducir oLicenciaConducir)
        {

            // Abrir Conexión 
            cn.Open();

            // Definir SP a Ejecutar: En este ejemplo es sp_CrearCliente
            SqlCommand cmd = new SqlCommand("sp_Crear_LicenciaConducir", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            // Asignado valores a los parámetros de entrada
            // Los valores se obtendrán de un objeto de la Entidad Cliente
            cmd.Parameters.AddWithValue("@numerolicencia", oLicenciaConducir.NumeroLicencia);
            cmd.Parameters.AddWithValue("@fechaemision", oLicenciaConducir.FechaEmision);
            cmd.Parameters.AddWithValue("@fechaexpiracion", oLicenciaConducir.FechaExpiracion);
            cmd.Parameters.AddWithValue("@categoria", oLicenciaConducir.Categoria);
            cmd.Parameters.AddWithValue("@clase", oLicenciaConducir.Clase);


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

        public DataTable Buscar_LicenciaConducir(int Id)
        {

            cn.Open();
            SqlCommand cmd = new SqlCommand("sp_Buscar_LicenciaConducir", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", Id);
            cn.Close();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;

        }


        public string Actualizar_LicenciaConducir(LicenciaConducir oLicenciaConducir)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("sp_Actualizar_LicenciaConducir", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", oLicenciaConducir.Id);
            cmd.Parameters.AddWithValue("@numerolicencia", oLicenciaConducir.NumeroLicencia);
            cmd.Parameters.AddWithValue("@fechaemision", oLicenciaConducir.FechaEmision);
            cmd.Parameters.AddWithValue("@fechaexpiracion", oLicenciaConducir.FechaExpiracion);
            cmd.Parameters.AddWithValue("@categoria", oLicenciaConducir.Categoria);
            cmd.Parameters.AddWithValue("@clase", oLicenciaConducir.Clase);


            // El nombre del parámetro de salida del sp es @resultado
            SqlParameter param = new SqlParameter("@resultado", SqlDbType.VarChar, 50);
            param.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(param);

            cmd.ExecuteNonQuery();
            cn.Close();

            //Devuelve el valor del parámetro de salida @resultado
            return cmd.Parameters["@resultado"].Value.ToString();
        }

        public int Eliminar_LicenciaConducir(int Id)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("sp_Eliminar_LicenciaConducir", cn);
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
