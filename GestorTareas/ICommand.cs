namespace GestorTareas
{
    public interface ICommand
    {
        public void Ejecutar();
        public void Deshacer();
    }
}
