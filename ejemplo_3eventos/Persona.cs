using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_3eventos
{
    class Persona
    {
        public string Nombre { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public string  Mavel { get; set; }

        public string  Heroe { get; set; }

        public string SagaFavorita { get; set; }

        public string Copas { get; set; }

        public string saludar()
        {
            return "Nombre: " + Nombre + " Fecha de Nacimiento: " + FechaNacimiento + " Le gustá marvel: " + Mavel+ 
                " El personaje Favorito de Mavel es: " + Heroe + " La saga favorita: " +SagaFavorita+ 
                " La cantidad de copas que tiene: " + Copas;

        }



    }
}
