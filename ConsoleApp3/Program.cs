// See https://aka.ms/new-console-template for more information
using Bibliotecaa;

Biblioteca biblioteca = new Biblioteca();
int accion = 0;
while (accion != 7) {
    string strVar1 = "";
    string strVar2 = "";
    int intVar1 = 0;
    int intVar2 = 0;
    bool response = false;
    

    Console.WriteLine("Bienvenido a la biblioteca \n 1-Agregar un libro \n 2-Registrar un usuario \n 3-Prestar un libro \n 4-Devolver un libro \n 5-Ver el estado de todos los libros" +
    "\n 6-Ver libros prestados a un usuario \n 7-Salir \n Seleccionar una opcion ");

    accion = int.Parse(Console.ReadLine());
    switch (accion) {
        case 1:
            {    Console.WriteLine("Ingrese el título del libro: ");
                 strVar1 = Console.ReadLine();
                 Console.WriteLine("Ingrese el autor del libro");
                 strVar2 = Console.ReadLine();
                 Console.WriteLine("Ingrese el ISBN del libro");
                 intVar1 = int.Parse(Console.ReadLine());
                 Libro libro = new Libro(strVar1, strVar2, intVar1);
                 biblioteca.agregarLibros(libro);
                 Console.WriteLine("Libro agregado con éxito.");
                 break;
            }

        case 2:
            {
                Console.WriteLine("Ingrese el nombre de usuario: ");
                strVar1 = Console.ReadLine();
                Console.WriteLine("Ingrese el ID del usuario: ");
                intVar1 = int.Parse(Console.ReadLine());
                Usuario usuario = new Usuario(intVar1, strVar1);
                biblioteca.agregarUsuarios(usuario);
                Console.WriteLine("Usuario registrado con éxito.");
                break;
            }
        case 3:
            {
                Console.WriteLine("Ingrese el ISBN del libro a prestar: ");
                intVar1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el Id del usuario: ");
                intVar2 = int.Parse(Console.ReadLine());
                response = biblioteca.prestarLibro(intVar1, intVar2);
                if (response == true)
                {
                    Console.WriteLine("Libro prestado con éxito");
                }
                else
                {
                    Console.WriteLine("Error al prestar libro");
                }
                break;
            }
        case 4:
            {
                Console.WriteLine("Ingrese el ISBN a devolver: ");
                intVar1 = int.Parse(Console.ReadLine());
                response = biblioteca.devolverLibro(intVar1);
                if (response == true)
                {
                    Console.WriteLine("Libro devuelto con éxito.");
                }
                else {
                    Console.WriteLine("Ocurrio un error");
                }
                break;
            }
        case 5:
            {
                Console.WriteLine("Estado de los libros: \n"+ biblioteca.mostrarLibros());
                biblioteca.mostrarLibros();
                break;
            }
        case 6: 
            {
                Console.WriteLine("Ingrese el Id del usuario: ");
                intVar1 = int.Parse(Console.ReadLine());
                Console.WriteLine(biblioteca.mostrarLibrosPrestadosAUsuario(intVar1));
                break;
            }
        case 7:
            {
                Console.WriteLine("Saliendo de la aplicacion.");
                break;
            }
        default: 
            {
                Console.WriteLine("opción errónea");
                break;
            }
    }
        

}


