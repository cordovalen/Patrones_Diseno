namespace GestorTareas
{
    public class CommandCompletarTarea : ICommand
    {
        private Tarea _tarea;

        public CommandCompletarTarea(Tarea tarea)
        {
            _tarea = tarea;
        }

        public void Deshacer()
        {
            _tarea.Completada = false;
            Console.WriteLine($"[DESHACER] La tarea {_tarea.Id} ha sido desmarcada como 'completada'.");
        }

        public void Ejecutar()
        {
            _tarea.Completar();
        }
    }
}
