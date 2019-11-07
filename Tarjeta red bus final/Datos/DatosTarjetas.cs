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
    public class DatosTarjetas:DatosConexionDB
    {

        public int abmTarjeta(string accion, Tarjeta objTarjeta)
        {
            int resultado = -1;
            string orden = string.Empty;

            if (accion == "Agregar")
                orden = "insert into Tarjetas values ('" + objTarjeta.Nombre +"', "+ objTarjeta.DNITarjeta +
                    ",'" + objTarjeta.Saldo + "') ;";
            if (accion == "Modificar")
                orden = "update Tarjetas set DNITarjeta= " +objTarjeta.DNITarjeta+ "update Tarjetas set DNITarjeta=" + objTarjeta.Saldo +  "," +
                   objTarjeta.Nombre+";";

            SqlCommand cmd = new SqlCommand(orden, conexion);

            try
            {
                Abrirconexion();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Errror al tratar de guardar,borrar o modificar de Tarjeta", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return resultado;
        }

        #region metodoListadoProf
        public DataSet listadoTarjeta(string cual)
        {
            string orden = string.Empty;
            if (cual != "Todos")
                orden = " select *from Tarjetas where Saldo = " + int.Parse(cual) + ";";
            else
                orden = "select * from Tarjetas;";

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

                throw new Exception("Error al listar Tarjeta", e);
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