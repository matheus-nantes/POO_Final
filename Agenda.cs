using System;
using System.Collections.Generic;

namespace AgendaPersonal
{
    public class Agenda
    {
        private List<ElementoAgenda> elementos = new List<ElementoAgenda>();

        public void AgregarElemento(ElementoAgenda elemento)
        {
            elementos.Add(elemento);
            Console.WriteLine($"Elemento '{elemento.Nombre}' agregado con éxito.");
        }

        public void ListarElementos()
        {
            if (elementos.Count == 0)
            {
                Console.WriteLine("La agenda está vacía.");
                return;
            }

            Console.WriteLine("\nElementos en la agenda:");
            foreach (var elemento in elementos)
            {
                elemento.MostrarInformacion();
            }
        }

        public void BuscarElemento(string nombre)
        {
            var elemento = elementos.Find(e => e.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));
            if (elemento != null)
            {
                Console.WriteLine("\nElemento encontrado:");
                elemento.MostrarInformacion();
            }
            else
            {
                Console.WriteLine($"Elemento '{nombre}' no encontrado.");
            }
        }

        public void EditarElemento(string nombre, string nuevoNombre)
        {
            var elemento = elementos.Find(e => e.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));
            if (elemento != null)
            {
                elemento.Nombre = nuevoNombre;
                Console.WriteLine($"Elemento '{nombre}' actualizado a '{nuevoNombre}'.");
            }
            else
            {
                Console.WriteLine($"Elemento '{nombre}' no encontrado.");
            }
        }

        public void EliminarElemento(string nombre)
        {
            var elemento = elementos.Find(e => e.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));
            if (elemento != null)
            {
                elementos.Remove(elemento);
                Console.WriteLine($"Elemento '{nombre}' eliminado con éxito.");
            }
            else
            {
                Console.WriteLine($"Elemento '{nombre}' no encontrado.");
            }
        }
    }
}
