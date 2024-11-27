namespace AgendaPersonal
{
    public abstract class ElementoAgenda
    {
        public string Nombre { get; set; }

        public ElementoAgenda(string nombre)
        {
            Nombre = nombre;
        }

        public abstract void MostrarInformacion(); // Método abstrato

        public abstract string ObtenerDetalles(); // Exemplo de abstração
    }
}
