namespace GestorTareas
{
    public interface ICommand
    {
        void Ejecutar();
        void Deshacer();
    }
}
