namespace AgendaPersonal
{
    public class Evento : ElementoAgenda
    {
        public DateTime Fecha { get; private set; }
        public string Descripcion { get; private set; }

        public Evento(string nombre, DateTime fecha, string descripcion)
            : base(nombre)
        {
            Fecha = fecha;
            Descripcion = descripcion;
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine($"[Evento] {Nombre} - Fecha: {Fecha}, Descripción: {Descripcion}");
        }

        public override string ObtenerDetalles()
        {
            return $"Evento: {Nombre} - Fecha: {Fecha} - Descripción: {Descripcion}";
        }
    }
}
