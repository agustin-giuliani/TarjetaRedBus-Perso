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
    public class NegocioPersona
    {
        DatosPersonas objDatPersona = new DatosPersonas();
        public int abmPersonas(string accion, Persona objPersonas)
        {
            return objDatPersona.abmPersonas(accion, objPersonas);

        }
        public DataSet listadoPersona(string cual)
        {
            return objDatPersona.listadoPersona(cual);
        }

    }
}
