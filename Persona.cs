namespace AgendaPersonal
{
    public class Persona : ElementoAgenda
    {
        public string Telefono { get; set; }

        public Persona(string nombre, string telefono) : base(nombre)
        {
            Telefono = telefono;
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}, Teléfono: {Telefono}");
        }

        public override string ObtenerDetalles()
        {
            return $"Nombre: {Nombre}, Teléfono: {Telefono}";
        }
    }
}
