using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Tarjeta
    {
        #region atributos
        private int dniTarjeta;
        private string nombre;
        private int saldo;
        #endregion

        #region constructor
        public void Tarjetas()
        {
            dniTarjeta = 0;
            saldo = 0;
            nombre = string.Empty;
        }
        #endregion

        #region
        public int DNITarjeta
        {
            get { return dniTarjeta; }
            set { dniTarjeta = value; }
        }
        public int Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        #endregion

    }
}
