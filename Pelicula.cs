using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_GrupoB
{
    public class Pelicula
    {

        public int id { get; set; }
        public string nombre { get; set; }
        public string sinopsis { get; set; }
        public string poster { get; set; }              
        public int duracion { get; set; } /* en minutos */

        public Pelicula(int id, string nombre, string sinopsis, string poster, int duracion )
        {
            this.id = id;
            this.nombre = nombre;
            this.sinopsis = sinopsis;  
            this.poster = poster;   
            this.duracion = duracion;
            List<Funcion> misFunciones = new List<Funcion>();
    }


    }
}
