using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_GrupoB
{
    internal class Pelicula
    {

        public int id { get; set; }
        public string nombre { get; set; }
        public string sinopsis { get; set; }
        public string poster { get; set; }
        
        public List<Funcion> misFunciones = new List<Funcion>();
        public int duracion { get; set; }

        public Pelicula()
        {

        }

    }
}
