using System;

namespace AgendaPersonal
{
    class Program
    {
        static void Main(string[] args)
        {
            Agenda miAgenda = new Agenda();
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("\n=== Menu Agenda Personal ===");
                Console.WriteLine("1. Agregar Contacto Familiar");
                Console.WriteLine("2. Agregar Contacto Profesional");
                Console.WriteLine("3. Agregar Evento");
                Console.WriteLine("4. Listar Elementos");
                Console.WriteLine("5. Buscar Elemento");
                Console.WriteLine("6. Editar Elemento");
                Console.WriteLine("7. Eliminar Elemento");
                Console.WriteLine("8. Salir");
                Console.Write("Seleccione una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        AgregarContactoFamiliar(miAgenda);
                        break;
                    case "2":
                        AgregarContactoProfesional(miAgenda);
                        break;
                    case "3":
                        AgregarEvento(miAgenda);
                        break;
                    case "4":
                        miAgenda.ListarElementos();
                        break;
                    case "5":
                        BuscarElemento(miAgenda);
                        break;
                    case "6":
                        EditarElemento(miAgenda);
                        break;
                    case "7":
                        EliminarElemento(miAgenda);
                        break;
                    case "8":
                        continuar = false;
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente nuevamente.");
                        break;
                }
            }
        }

        // Métodos para manejar las opciones del menú
        static void AgregarContactoFamiliar(Agenda agenda)
        {
            Console.Write("Ingrese el nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese el teléfono: ");
            string telefono = Console.ReadLine();
            Console.Write("Ingrese la relación: ");
            string relacion = Console.ReadLine();

            agenda.AgregarElemento(new ContactoFamiliar(nombre, telefono, relacion));
        }

        static void AgregarContactoProfesional(Agenda agenda)
        {
            Console.Write("Ingrese el nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese el teléfono: ");
            string telefono = Console.ReadLine();
            Console.Write("Ingrese la empresa: ");
            string empresa = Console.ReadLine();
            Console.Write("Ingrese el correo: ");
            string correo = Console.ReadLine();

            agenda.AgregarElemento(new ContactoProfesional(nombre, telefono, empresa, correo));
        }

        static void AgregarEvento(Agenda agenda)
        {
            Console.Write("Ingrese el nombre del evento: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese la fecha (formato YYYY-MM-DD): ");
            DateTime fecha;
            while (!DateTime.TryParse(Console.ReadLine(), out fecha))
            {
                Console.Write("Fecha no válida. Intente nuevamente (YYYY-MM-DD): ");
            }
            Console.Write("Ingrese la descripción: ");
            string descripcion = Console.ReadLine();

            agenda.AgregarElemento(new Evento(nombre, fecha, descripcion));
        }

        static void BuscarElemento(Agenda agenda)
        {
            Console.Write("Ingrese el nombre del elemento a buscar: ");
            string nombre = Console.ReadLine();
            agenda.BuscarElemento(nombre);
        }

        static void EditarElemento(Agenda agenda)
        {
            Console.Write("Ingrese el nombre del elemento a editar: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese el nuevo nombre: ");
            string nuevoNombre = Console.ReadLine();
            agenda.EditarElemento(nombre, nuevoNombre);
        }

        static void EliminarElemento(Agenda agenda)
        {
            Console.Write("Ingrese el nombre del elemento a eliminar: ");
            string nombre = Console.ReadLine();
            agenda.EliminarElemento(nombre);
        }
    }
}
