using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_GrupoB
{
    internal class Sala
    {
        public int id { get; set; }
        public string ubicacion { get; set; }
        public int capacidad { get; set; }

        public List<Funcion> misFunciones = new List<Funcion>();

        public Sala() { 
        }


    }
}
