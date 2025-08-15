namespace GestorTareas
{
    public class CommandCrear : ICommand
    {
        private Tarea _tarea;

        public CommandCrear(Tarea tarea)
        {
            _tarea = tarea;
        }

        public void Deshacer()
        {
            Console.WriteLine($"[DESHACER] La creación de la tarea #{_tarea.Id} ha sido deshecha.");
        }

        public void Ejecutar()
        {
            _tarea.Crear();
        }
    }
}
