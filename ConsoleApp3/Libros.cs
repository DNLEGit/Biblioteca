using Bibliotecaa;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotecaa
{
    public class Libro

    {
        public string Autor { get; set; }
        public string Nombre { get; set; }
        public int ISBN { get; set; }
        public bool Disponible { get; set; }

        public Libro(string Nombre, string Autor, int ISBN)
        {

            this.Autor = Autor;
            this.Nombre = Nombre;
            this.ISBN = ISBN;
            this.Disponible = true;

        }

        

        
    }
        


    public class Usuario {

        public int Id { get; set; }

        public string Nombre { set; get; }

        public string[] ListaDeLibros { set; get; }

        public Usuario(int Id, string Nombre){
            
            this.Id = Id;
            this.Nombre = Nombre;
            this.ListaDeLibros = new string[99];
            
        }
        public void agregarLibroAUsuario(Libro libro) {
            bool var = true;
            int i = 0;
            while (var == true) {
         
                if (this.ListaDeLibros[i] == null ) {
                    this.ListaDeLibros[i] = libro.Nombre;
                    var = false;
                }
                i++;
                
            }
        }

    }


    public class Biblioteca
    {
        List<Libro> libreria = new List<Libro>();
        List<Usuario> listaUsuarios = new List<Usuario>();

        public void agregarLibros(Libro libro){
            libreria.Add(libro);
        }
        public void agregarUsuarios(Usuario usuario) { 
            listaUsuarios.Add(usuario);
        }
        public string mostrarLibros() {
            string dat = ""; 
            foreach (Libro libro in libreria) {
                
                dat += $"-Titulo: {libro.Nombre}, Autor: {libro.Autor}, ISBN: {libro.ISBN}, Disponible: {libro.Disponible}" + "\n";
                                
            }

            return dat;
        }
        public bool prestarLibro(int ISBM, int id) {
            foreach (Libro libro in libreria) {
                if (libro.ISBN == ISBM && libro.Disponible == true) {
                    libro.Disponible = false;
                    foreach (Usuario usuario in listaUsuarios) {
                        if (usuario.Id == id) {
                            usuario.agregarLibroAUsuario(libro);
                        }
                    }
                    return true;
                }
            }
            return false;
        }
        public bool devolverLibro(int ISBN) {
            foreach (Libro libro in libreria) {
                if(libro.ISBN == ISBN) {
                    libro.Disponible = true;  
                    return true;
                }
            }
            return false;
        }
        public string mostrarLibrosPrestadosAUsuario(int ID) {
            string var = "";
            foreach (Usuario usuario in listaUsuarios) {
                if (usuario.Id == ID) {
                    foreach (var libro in usuario.ListaDeLibros) {
                        if (libro != null) {
                            var += libro + "\n"; 
                        }
                    } 
                }return var;
            }
            return "El usuario no tiene ningun libro en su historial";
        }

    }
    }


