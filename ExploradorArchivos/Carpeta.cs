namespace ExploradorArchivos
{
    public class Carpeta : IComponent
    {
        public string Nombre { get; }
        private List<IComponent> _elementos = [];

        public Carpeta(string nombre)
        {
            Nombre = nombre;
        }

        public void Agregar(IComponent componente)
        {
            _elementos.Add(componente);
        }

        public void Eliminar(IComponent componente)
        {
            _elementos.Remove(componente);
        }

        public long ObtenerTamano()
        {
            long tamanoTotal = 0;
            foreach (var componente in _elementos)
            {
                tamanoTotal += componente.ObtenerTamano();
            }
            return tamanoTotal;
        }

        public void Mostrar(int profundidad)
        {
            Console.WriteLine(new string(' ', profundidad * 2) + $"{Nombre}");
            foreach (var componente in _elementos)
            {
                componente.Mostrar(profundidad + 1); 
            }
        }
    }
}
