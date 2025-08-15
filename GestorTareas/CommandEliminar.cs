namespace GestorTareas
{
    public class CommandEliminar : ICommand
    {
        private Tarea _tarea;

        public CommandEliminar(Tarea tarea)
        {
            _tarea = tarea;
        }

        public void Deshacer()
        {
            Console.WriteLine($"[DESHACER] La eliminación de la tarea {_tarea.Id} ha sido exitosa.\n (La tarea no puede ser recuperada)");
        }

        public void Ejecutar()
        {
            _tarea.Eliminar();
        }
    }
}
