namespace GestorTareas
{
    public class CommandEliminar : ICommand
    {
        private readonly Tarea _tarea;

        public CommandEliminar(Tarea tarea)
        {
            _tarea = tarea;
        }

        public void Deshacer()
        {
            _tarea.Completada = EstadosTareaEnum.eliminada.GetHashCode();
            Console.WriteLine($"[DESHACER] La eliminación de la tarea {_tarea.Id} ha sido exitosa.\n (La tarea no puede ser recuperada)");
        }

        public void Ejecutar()
        {
            _tarea.Eliminar();
        }
    }
}
