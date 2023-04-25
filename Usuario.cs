using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_GrupoB
{
    public class Usuario
    {
        // falta misFunciones lista

        public int id { get; set; }
        public int dni { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string mail { get; set; }
        public string contrasenia { get; set; }
        public int intentosFallidos { get; set; }
        public bool isBloqueado { get; set; }

        public List<Funcion> misFunciones = new List<Funcion>();
        public double credito { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public bool isAdmin { get; set; }


        public Usuario() { }

        public Usuario(string Mail, string Contrasenia) { 
            mail = Mail;
            contrasenia = Contrasenia;
        }
        public Usuario(int id, int Dni, string Nombre, string Apellido, string Mail,string Contrasenia) {       
            dni = Dni;
            nombre = Nombre;
            apellido = Apellido;
            mail = Mail;
            contrasenia = Contrasenia;
        }


        /* En el ejemplo del profesor en clase...
        public Usuario(string Nombre, string Contrasenia)
        {
            nombre = Nombre;
            contrasenia = Contrasenia;
        }

        public Usuario(string Nombre, string Contrasenia, int ID)
        {
            nombre = Nombre;
            contrasenia = Contrasenia;
            id = ID;
        }


         public string[] ToString() { 
            return new string[] {id.ToString(), nombre, contrasenia}
            }
        

        */


    }
}
