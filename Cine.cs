using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net.Mail;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace TP1_GrupoB
{
    public class Cine
    {
        #region atributos
        public List<Usuario> clientes {  get; set; }

        public List<Usuario> usuarios { get; set; }
        public int idUsuarios{ get; set; }
        public int idFunciones { get; set; }
        public int idPeliculas{ get; set; }
        public int idSalas { get; set; }
        public List<Funcion> funciones { get; set; }
        public List<Sala> salas { get; set; }
        public List<Pelicula> peliculas { get; set; }
        public Usuario Logueado { get; set; }
        
        
        #endregion

        public Cine()
        {
            clientes = new List<Usuario>();
            usuarios = new List<Usuario>();
            idUsuarios = 1;
            idFunciones = 1;
            idPeliculas = 1;
            idSalas = 1;
            funciones = new List<Funcion>();
            salas= new List<Sala>();
            peliculas= new List<Pelicula>();
        
        }
  

        #region INICIAR SESION

        public Tuple<int, int> iniciarSesion(string mail, string contrasenia)
        {
            int flag = 0;

            foreach (Usuario usu in usuarios)
            {
                if (!usu.mail.Equals(mail, StringComparison.OrdinalIgnoreCase))
                {
                    flag = 4;
                    continue;
                }
                if (usu.mail.Equals(mail, StringComparison.OrdinalIgnoreCase) && usu.contrasenia.Equals(contrasenia) && !usu.isBloqueado)
                {
                    Logueado = usu;
                    flag = 1;
                    return Tuple.Create(flag, 0);
                }

                if (usu.mail.Equals(mail, StringComparison.OrdinalIgnoreCase) && !usu.contrasenia.Equals(contrasenia) && usu.intentosFallidos < 3)
                {
                    usu.intentosFallidos++;
                    flag = 2;
                    return Tuple.Create(flag, usu.intentosFallidos);               
                }

                if (usu.isBloqueado == true || usu.intentosFallidos > 3)
                {                   
                    flag = 3;
                    return Tuple.Create(flag, 0);
                }
               
            }
            return Tuple.Create(flag, 0); ;
        }





# endregion




        #region LISTADOS
      
        public List<Usuario> obtenerUsuarios() { 
            return usuarios.ToList();
        }
        public List<Funcion> obtenerFuncion() { 
            return funciones.ToList();
        }
        public List<Sala> obtenerSalas() { 
            return salas.ToList();
        }
        public List<Pelicula> obtenerPeliculas() { 
        return peliculas.ToList();
        }



        #endregion

        #region METODOS AGREGAR

        public bool agregarUsuario(string dni, string nombre, string apellido, string mail, string contrasenia,double credito,bool isAdmin)
        {
            usuarios.Add(new Usuario(idUsuarios, dni, nombre, apellido, mail, contrasenia,credito,isAdmin));
            idUsuarios++;
            return true;
        }
        
        public bool agregarFuncion(string ubicacionSala, string tituloPelicula, DateTime fechadouble, int costo)
        {
            
            Sala miSala = null;
            foreach (Sala sal in salas)
            {
                if (sal.ubicacion == ubicacionSala)
                {
                    miSala = sal;
                    break;
                }
            }

            Pelicula miPelicula = null;

            foreach (Pelicula peli in peliculas)
            {
                if (peli.nombre == tituloPelicula)
                {
                    miPelicula = peli;
                    break;
                }
            }


            Usuario misUsuarios = null;

            foreach (Usuario usu in usuarios)
            {
                if (usu ==Logueado)
                {
                    misUsuarios = usu;
                    break;
                }
            }



            if (miSala != null && miPelicula != null && misUsuarios != null)
            {


                Funcion miFuncion = new Funcion(idFunciones, miSala, miPelicula, misUsuarios, fechadouble, 0, costo);

                miPelicula.misFunciones.Add(miFuncion);
                miSala.misFunciones.Add(miFuncion);
                misUsuarios.misFunciones.Add(miFuncion);

                funciones.Add(new Funcion(idFunciones, miSala, miPelicula, misUsuarios, fechadouble,0, costo));
                idFunciones++;

               
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool agregarPelicula(string nombre, string sinopsis, string poster, int duracion)
        {
            peliculas.Add(new Pelicula(idPeliculas, nombre, sinopsis, poster, duracion));
            idPeliculas++;
            return true;
        }

        public bool agregarSala(string ubicacion, int capacidad)
        {
            salas.Add(new Sala(idSalas, ubicacion, capacidad));
            idSalas++;
            return true;
        }



        #endregion

        #region METODOS MODIFICAR

        //MODIFICAR
        public bool modificarUsuario(int id,string dni, string nombre, string apellido, string mail, string contrasenia,double newCredito, bool isAdmin)
        {
            foreach (Usuario usu in usuarios)
            {
                if (usu.id == id)
                {
                    usu.nombre = nombre;
                    usu.apellido = apellido;
                    usu.dni = dni;
                    usu.mail = mail;
                    usu.credito = newCredito;
                    usu.contrasenia = contrasenia;
                    usu.isAdmin = isAdmin;
                    return true;
                }
            }
            return false;
        }

        public bool modificarPelicula(int id, string nombre, string sinopsis, string poster, int duracion)
        {
            foreach (Pelicula peli in peliculas)
            {
                if (peli.id == id)
                {
                    peli.nombre = nombre;
                    peli.sinopsis = sinopsis;
                    peli.poster = poster;
                    peli.duracion = duracion;
                  
                    return true;
                }
            }
            return false;
        }


        public bool modificarSala(int id, string ubicacion, int capacidad)
        {
            foreach (Sala sal in salas)
            {
                if (sal.id == id)
                {
                    sal.id = id;
                    sal.ubicacion = ubicacion;
                    sal.capacidad = capacidad;
                    idSalas--;
                    return true;
                }
            }
            return false;
        }

        public bool modificaFuncion(int id, string ubicacionSala, string  tituloPelicula, DateTime fechadouble, int costo)
        {
            Sala miSala = null;
            foreach (Sala sal in salas)
            {
                if (sal.ubicacion == ubicacionSala)
                {
                    miSala = sal;
                    break;
                }
            }

            Pelicula miPelicula = null;

            foreach (Pelicula peli in peliculas)
            {
                if (peli.nombre == tituloPelicula)
                {
                    miPelicula = peli;
                    break;
                }
            }


            Usuario misUsuarios = null;

            foreach (Usuario usu in usuarios)
            {
                if (usu == Logueado)
                {
                    misUsuarios = usu;
                    break;
                }
            }


            foreach (Funcion funcion in funciones)
            {
                if (funcion.id == id)
                {
                    funcion.id = id;
                    funcion.miSala= miSala;
                    funcion.pelicula = miPelicula;
                    funcion.fecha = fechadouble;
                    funcion.costo = costo;

                    return true;
                }
            }
            return false;
        }



        #endregion

        #region METODOS ELIMINAR
        //Eliminar usuarios
        public bool eliminarUsuario(int id)
        {
            foreach (Usuario usu in usuarios)
            {
                if (usu.id == id)
                {
                    usuarios.Remove(usu);
                    idUsuarios--;
                    return true;
                }
            }
            return false;
        }

        public bool eliminarPeliculas(int id)
        {
            foreach (Pelicula peli in peliculas)
            {
                if (peli.id == id)
                {
                    peliculas.Remove(peli);
                    idPeliculas--;
                    return true;
                }
            }
            return false;
        }

        public bool eliminarSalas(int id)
        {
            foreach (Sala sal in salas)
            {
                if (sal.id == id)
                {
                    salas.Remove(sal);
                    idSalas--;
                    return true;
                }
            }
            return false;
        }


        public bool eliminarFunciones(int id)
        {
            foreach (Funcion fun in funciones)
            {
                if (fun.id == id)
                {
                    funciones.Remove(fun);
                    idFunciones--;
                    return true;
                }
            }
            return false;
        }


        #endregion

        #region CERRAR SESION
        public void cerrarSesion()
        {
            Logueado = null;
        }
        #endregion

        #region LOGUEADO
        public string nombreLogueado()
        {
            return Logueado.nombre;
            
        }
        #endregion



          

        public int comprarEntradas(Usuario Logueado, int cantidad, int idFuncion)
        {
            int flag = 0;
            int contador= 0;
            foreach (Funcion f in funciones)
            {
                if (idFuncion == f.id)
                {                              
                    if (cantidad * f.costo <= Logueado.credito && f.miSala.capacidad > f.cantClientes)
                    {
                        flag = 1;
                        Logueado.credito -= cantidad * f.costo;
                        f.clientes.Add(Logueado);
                        f.cantClientes += cantidad; 
                         
                                             

                        f.miSala.capacidad -= cantidad; 
                       
             
                       return flag;
                    }
                    flag = 2;
                    return flag;
                }
            }              

            return flag;
        }
            
        
        


        public bool depositarCredito(int id, double credito, double monto)
        {
            bool encontrado = false;
            foreach (Usuario usu in usuarios)
            {
                if (usu.id == id)
                {
                    usu.credito = credito;

                    if (monto <= 0)
                    {
                        credito = credito + 0;
                    }
                    else
                    {
                        credito = credito + monto;
                    }
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return encontrado;
        }


    }

}
