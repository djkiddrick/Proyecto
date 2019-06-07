using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Animal : Persona
    {
        // Atributos
        private String raza;
        private String tipo;

        // Metodos set y get
        public void setRaza(String raza)
        {
            this.raza = raza;
        }

        public String getRaza()
        {
            return raza;
        }

        public void setTipo(String tipo)
        {
            this.tipo = tipo;
        }

        public String getTipo()
        {
            return tipo;
        }


    }
}
