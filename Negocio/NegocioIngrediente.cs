using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;


namespace Negocio
{
    public class NegocioIngrediente
    {
        public List<Ingrediente> listarIngrediente()
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            List<Ingrediente> listado = new List<Ingrediente>();
            Ingrediente nuevo;
            try
            {
                conexion.ConnectionString = "data source=(local); initial catalog=Ingredientes_DB; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select Nombre, CantidadIngrediente,Precio From INGREDIENTES";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    nuevo = new Ingrediente();
                    nuevo.NombreIngrediente = lector.GetString(0);
                    nuevo.CantidadIngrediente = lector.GetFloat(1);
                    nuevo.PrecioIngrediente = lector.GetFloat(2);
                    listado.Add(nuevo);
                }

                return listado;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }

        public void agregarIngrediente(Ingrediente nuevo)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            try
            {
                conexion.ConnectionString = "data source=(local); initial catalog=Ingredientes_DB; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "insert into INGREDIENTES (Nombre, CantidadIngrediente, Precio) values ('" + nuevo.NombreIngrediente + "','" + nuevo.CantidadIngrediente + "','" + nuevo.PrecioIngrediente + "')";
                comando.Connection = conexion;
                conexion.Open();

                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}
    
