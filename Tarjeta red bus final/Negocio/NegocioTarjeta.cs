using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Datos;
using Entidades;
using System.Threading.Tasks;

namespace Negocio
{
    public class NegocioTarjeta
    {
        DatosTarjetas objDatTarjeta = new DatosTarjetas();
        public int abmTarjeta(string accion,Tarjeta objTarjeta)
        {
           return objDatTarjeta.abmTarjeta(accion, objTarjeta);

        }
        public DataSet listadoTarjeta(string cual)
        {
            return objDatTarjeta.listadoTarjeta(cual);
        }



    }
}
