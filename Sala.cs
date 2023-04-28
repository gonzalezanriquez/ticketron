using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_GrupoB
{
    public class Sala
    {
        public int id { get; set; }
        public string ubicacion { get; set; }
        public int capacidad { get; set; }

        public List<Funcion> misFunciones = new List<Funcion>();

        public Sala(int id, string ubicacion, int capacidad)
        {
            this.id = id;
            this.ubicacion = ubicacion;
            this.capacidad = capacidad;

            List<Funcion> misFunciones = new List<Funcion>();
        }


    }
}
