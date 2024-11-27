namespace AgendaPersonal
{
    public class ContactoFamiliar : Persona
    {
        public string Relacion { get; private set; }

        public ContactoFamiliar(string nombre, string telefono, string relacion)
            : base(nombre, telefono)
        {
            Relacion = relacion;
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine($"[Familiar] Nombre: {Nombre}, Relación: {Relacion}");
        }

        public override string ObtenerDetalles()
        {
            return $"Familiar: {Nombre} - Relación: {Relacion}";
        }
    }
}
