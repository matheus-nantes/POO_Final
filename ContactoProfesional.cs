namespace AgendaPersonal
{
    public class ContactoProfesional : Persona
    {
        public string Empresa { get; private set; }
        public string Correo { get; private set; }

        public ContactoProfesional(string nombre, string telefono, string empresa, string correo)
            : base(nombre, telefono)
        {
            Empresa = empresa;
            Correo = correo;
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine($"[Profesional] Nombre: {Nombre}, Empresa: {Empresa}, Correo: {Correo}");
        }

        public override string ObtenerDetalles()
        {
            return $"Profesional: {Nombre} - Empresa: {Empresa} - Correo: {Correo}";
        }
    }
}
