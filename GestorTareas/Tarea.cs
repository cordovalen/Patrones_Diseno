namespace GestorTareas
{
    public class Tarea
    {
        public Guid Id { get; set; }
        public string Descripcion { get; set; }
        public int Completada { get; set; }

        public Tarea(Guid id, string descripcion)
        {
            Id = id;
            Descripcion = descripcion;
            Completada = EstadosTareaEnum.incompleta.GetHashCode();
        }

        public void Crear()
        {
            Console.WriteLine($"[ACCIÓN] Tarea #{Id} creada: '{Descripcion}'.");
        }

        public void Editar(string nuevaDescripcion)
        {
            string descripcionAnterior = Descripcion;
            Descripcion = nuevaDescripcion;
            Console.WriteLine($"[ACCIÓN] Tarea #{Id} editada de '{descripcionAnterior}' a '{Descripcion}'.");
        }

        public void Eliminar()
        {
            Console.WriteLine($"[ACCIÓN] Tarea #{Id} eliminada.");
        }

        public void Completar()
        {
            Completada = EstadosTareaEnum.completa.GetHashCode();
            Console.WriteLine($"[ACCIÓN] Tarea #{Id} completada.");
        }
    }
}
