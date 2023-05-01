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
        #region atributos
        public int id { get; set; }
        public string dni { get; set; }
        public string apellido { get; set; }
        public string nombre { get; set; }
        public string mail { get; set; }
        public string contrasenia { get; set; }
        public int intentosFallidos { get; set; }
        public bool isBloqueado { get; set; }

        public List<Funcion> misFunciones = new List<Funcion>();
        public double credito { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public bool isAdmin { get; set; }
        #endregion
       
        #region constructor
        public Usuario() { }

        public Usuario(string Mail, string Contrasenia) { 
            mail = Mail;
            contrasenia = Contrasenia;
        }
        public Usuario(int Id, string Dni, string Nombre, string Apellido, string Mail,string Contrasenia,bool IsAdmin) {
            id =Id;
            dni = Dni;
            nombre = Nombre;
            apellido = Apellido;
            mail = Mail;
            contrasenia = Contrasenia;
            isAdmin = IsAdmin;
            intentosFallidos=0;
            credito = 1000.00;
            isBloqueado = false;
            List<Funcion> misFunciones = new List<Funcion>();

        }

        #endregion




    }
}
