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

// Sección 1: Ejecución de Acciones
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("\n--- EJECUTANDO ACCIONES ---");
Console.ResetColor();

ICommand crearPrimeraTarea = new CommandCrear(primeraTarea);
gestor.EjecutarCommand(crearPrimeraTarea);

ICommand editarPrimeraTarea = new CommandEditar(primeraTarea, "Crear HU");
gestor.EjecutarCommand(editarPrimeraTarea);

ICommand completarPrimeraTarea = new CommandCompletarTarea(primeraTarea);
gestor.EjecutarCommand(completarPrimeraTarea);

ICommand crearSegundaTarea = new CommandCrear(segundaTarea);
gestor.EjecutarCommand(crearSegundaTarea);

// Sección 2: Estado Actual de las Tareas
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("\n--- ESTADO ACTUAL DE LAS TAREAS ---");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine($"- {primeraTarea.Descripcion} - ESTADO: {RevisarEstado(primeraTarea.Completada)})");
Console.WriteLine($"- {segundaTarea.Descripcion} - ESTADO: {RevisarEstado(segundaTarea.Completada)})");
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
Console.WriteLine($"- {primeraTarea.Descripcion} - ESTADO: {RevisarEstado(primeraTarea.Completada)})");
Console.WriteLine($"- {segundaTarea.Descripcion} - ESTADO: {RevisarEstado(segundaTarea.Completada)})");
Console.ResetColor();

static string RevisarEstado(bool estadoTarea)
{
    return estadoTarea ? "'completada'" : "'incompleta'";
}