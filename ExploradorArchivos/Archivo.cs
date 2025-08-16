namespace ExploradorArchivos
{
    public class Archivo : IComponent
    {
        public string Nombre { get; }
        private readonly long _tamano;

        public Archivo(string nombre, long tamano)
        {
            Nombre = nombre;
            _tamano = tamano;
        }

        public void Mostrar(int profundidad)
        {
            Console.WriteLine(new string(' ', profundidad * 2) + $"{Nombre} ({_tamano} bytes)");
        }

        public long ObtenerTamano()
        {
            return _tamano;
        }
    }
}
