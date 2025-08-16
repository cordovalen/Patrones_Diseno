namespace GestorTareas
{
    public class CommandEditar : ICommand
    {
        private readonly Tarea _tarea;
        private readonly string _nuevaDescripcion;
        private readonly string _descripcionAnterior;

        public CommandEditar(Tarea tarea, string nuevaDescripcion)
        {
            _tarea = tarea;
            _nuevaDescripcion = nuevaDescripcion;
            _descripcionAnterior = _tarea.Descripcion;
        }

        public void Deshacer()
        {
            _tarea.Descripcion = _descripcionAnterior;
            Console.WriteLine($"[DESHACER] La edición de la tarea {_tarea.Id} ha sido revertida. Descripción: '{_tarea.Descripcion}'.");
        }

        public void Ejecutar()
        {
            _tarea.Editar(_nuevaDescripcion);
        }
    }
}
