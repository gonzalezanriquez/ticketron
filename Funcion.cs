﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_GrupoB
{
    public class Funcion
    {
        public int id { get; set; }
        public Sala miSala { get; set; }
        public Pelicula pelicula { get; set; }
        public List<Usuario> clientes=new List<Usuario>();
        public DateTime fecha { get; set; }
        public int cantClientes { get; set; }
        public double costo { get; set; }
        
        public Funcion(int id, Sala miSala, Pelicula pelicula, Usuario usuarios, DateTime Fecha, int cantClientes, double costo)
        {
            this.id = id;
            this.cantClientes = cantClientes;
            this.costo = costo;
            this.fecha = Fecha;
            this.pelicula = pelicula;
            this.miSala = miSala;
            
        }

    }
}
