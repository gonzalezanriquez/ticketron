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
using static System.Collections.Specialized.BitVector32;

namespace TP1_GrupoB
{
    public class Cine
    {
        #region atributos
        public List<Usuario> usuarios {  get; set; }
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
            usuarios= new List<Usuario>();
            idUsuarios= 1;
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

        public bool agregarUsuario(string dni, string nombre, string apellido, string mail, string contrasenia,bool isAdmin)
        {
            usuarios.Add(new Usuario(idUsuarios, dni, nombre, apellido, mail, contrasenia,isAdmin));
            idUsuarios++;
            return true;
        }
        int puto;
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


            

            if (miSala != null || miPelicula != null)
            {

                int cantClientes=0;

                Funcion miFuncion = new Funcion(idFunciones, miSala, miPelicula, misUsuarios, fechadouble, cantClientes, costo);

                miPelicula.misFunciones.Add(miFuncion);                
                miSala.misFunciones.Add(miFuncion);


        
                ////if (comprarEntrada(misUsuarios,))
                ////{
                ////    misUsuarios.misFunciones.Add(miFuncion);
                ////    cantClientes++;
                ////    miSala.capacidad--;


                ////}                


                funciones.Add(new Funcion(idFunciones, miSala, miPelicula, misUsuarios, fechadouble, 35, costo));
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
        public bool modificarUsuario(int id,string dni, string nombre, string apellido, string mail, string contrasenia,bool isAdmin)
        {
            foreach (Usuario usu in usuarios)
            {
                if (usu.id == id)
                {
                    usu.nombre = nombre;
                    usu.apellido = apellido;
                    usu.dni = dni;
                    usu.mail = mail;
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



        #region METODO COMPRA DE ENTRADAS
        public bool comprarEntrada(Usuario Logueado, int cantidad)
        {
            foreach (Funcion f in funciones) {

                Boolean compra = false;

                if (cantidad +f.cantClientes < f.miSala.capacidad)
                {
                   
                }
                   

                if (Logueado.credito > f.costo) {

                    compra = true;
                }
                   ;
                    compra = false;

                if (!compra)
                {
                 
                    break;

                }

                
             
                Logueado.credito = Logueado.credito - f.costo;
                f.clientes.Add(Logueado);

                f.cantClientes = f.cantClientes + cantidad;          
            }
            return true;
        }
        #endregion


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
