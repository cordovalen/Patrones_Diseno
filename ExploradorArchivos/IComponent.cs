namespace ExploradorArchivos
{
    public interface IComponent
    {
        string Nombre { get; }
        long ObtenerTamano();
        void Mostrar(int profundidad);
    }
}
