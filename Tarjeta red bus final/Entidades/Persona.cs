using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        #region atributos
        private string nombre;
        private string apellido;
        private int dni;
        private Char sexo;
        private string fechaNac;
        private int cuild;
        #endregion

        #region constructor
        public void Personas()
        {
            nombre = string.Empty;
            apellido = string.Empty;
            dni = 0;
            sexo = Char.Parse(string.Empty);
            fechaNac = string.Empty;
            cuild = 0;
        }
        #endregion

        #region
        public int DNI
        {
            get { return dni; }
            set { dni = value; }
        }
        public int Cuild
        {
            get { return cuild; }
            set { cuild = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public char Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public string FechaNac
        {
            get { return fechaNac; }
            set { fechaNac = value; }
        }
        #endregion

    }
}
