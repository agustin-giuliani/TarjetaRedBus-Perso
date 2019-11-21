using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Entidades;
using System.Threading.Tasks;

namespace Datos
{
    public class DatosPersonas : DatosConexionDB
    {
        public int abmPersonas(string accion, Persona objPersonas)
        {
            int resultado = -1;
            string orden = string.Empty;

            if (accion == "Agregar")
                orden = "insert into Personas values ('" + objPersonas.Nombre + "', '" + objPersonas.Apellido +
                    "', '" + objPersonas.Sexo + "', '"+objPersonas.FechaNac +"', "+objPersonas.DNI+", "+objPersonas.Cuild+") ;";
            if (accion == "Modificar")
                orden = "update Personas set DNI= '" + objPersonas.Nombre + "', '" + objPersonas.Apellido + "', '" +
                   objPersonas.Sexo + "', '"+objPersonas.FechaNac +"', "+objPersonas.DNI+", "+objPersonas.Cuild+";";

            SqlCommand cmd = new SqlCommand(orden, conexion);

            try
            {
                Abrirconexion();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Errror al tratar de guardar,borrar o modificar de Personas", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return resultado;
        }

        #region metodoListadoProf
        public DataSet listadoPersona(string cual)
        {
            string orden = string.Empty;
            if (cual != "Todos")
                orden = " select *from Personas where Nombre = " + int.Parse(cual) + ";";
            else
                orden = "select * from Personas;";

            SqlCommand cmd = new SqlCommand(orden, conexion);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();

            try
            {
                Abrirconexion();
                cmd.ExecuteNonQuery();

                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception e)
            {

                throw new Exception("Error al listar Personas", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return ds;
        }
        #endregion
    }
}
