// See https://aka.ms/new-console-template for more information

using GestorTareas;

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("==============================================");
Console.WriteLine("       GESTOR DE TAREAS       ");
Console.WriteLine("==============================================");
Console.ResetColor();

GestorTarea gestor = new();
Tarea primeraTarea = new(Guid.NewGuid(), "Crear Historia de usuario");
Tarea segundaTarea = new(Guid.NewGuid(), "Crear DOR");
Tarea terceraTarea = new(Guid.NewGuid(), "Crear Historia técnica");

// Sección 1: Ejecución de Acciones
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("\n--- EJECUTANDO ACCIONES ---");
Console.ResetColor();

ICommand crearPrimeraTarea = new CommandCrear(primeraTarea);
gestor.EjecutarCommand(crearPrimeraTarea);

ICommand crearTeceraTarea = new CommandCrear(terceraTarea);
gestor.EjecutarCommand(crearTeceraTarea);

ICommand editarPrimeraTarea = new CommandEditar(primeraTarea, "Crear HU");
gestor.EjecutarCommand(editarPrimeraTarea);

ICommand completarPrimeraTarea = new CommandCompletarTarea(primeraTarea);
gestor.EjecutarCommand(completarPrimeraTarea);

ICommand crearSegundaTarea = new CommandCrear(segundaTarea);
gestor.EjecutarCommand(crearSegundaTarea);

ICommand eliminarTerceraTarea = new CommandEliminar(terceraTarea);
gestor.EjecutarCommand(eliminarTerceraTarea);


// Sección 2: Estado Actual de las Tareas
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("\n--- ESTADO ACTUAL DE LAS TAREAS ---");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Yellow;
RevisarEstado([primeraTarea, segundaTarea, terceraTarea]);
Console.ResetColor();

// Sección 3: Deshaciendo Acciones
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("\n--- DESHACIENDO ACCIONES ---");
Console.ResetColor();

gestor.DeshacerCommand(); // Deshace 'Completar Tarea'
gestor.DeshacerCommand(); // Deshace 'Editar Tarea'

// Sección 4: Estado Final de las Tareas
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("\n--- ESTADO FINAL DE LAS TAREAS ---");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Yellow;
RevisarEstado([primeraTarea, segundaTarea, terceraTarea]);
Console.ResetColor();

static void RevisarEstado(List<Tarea> tareas)
{
    foreach (Tarea tarea in tareas)
    {
        string estado = string.Empty;
        if (!Enum.IsDefined(typeof(EstadosTareaEnum), tarea.Completada))
           estado = "Estado desconocido";

        EstadosTareaEnum estadoTarea = (EstadosTareaEnum)tarea.Completada;
        estado = estadoTarea switch
        {
            EstadosTareaEnum.completa => "Completada",
            EstadosTareaEnum.incompleta => "Incompleta",
            EstadosTareaEnum.eliminada => "Eliminada",
            _ => "Estado desconocido"
        };
        Console.WriteLine($"- {tarea.Descripcion} - ESTADO: {estado})");
    }
    
}
