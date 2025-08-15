namespace GestorTareas
{
    public class GestorTarea
    {
        private List<ICommand> _historial = [];

        public void EjecutarCommand(ICommand command)
        {
            command.Ejecutar();
            _historial.Add(command);
        }

        public void DeshacerCommand()
        {
            if (_historial.Count > 0)
            {
                ICommand ultimoCommand = _historial[^1];
                _historial.RemoveAt(_historial.Count - 1);
                ultimoCommand.Deshacer();
            }
            else
            {
                Console.WriteLine("No hay commands para deshacer.");
            }
        }
    }
}
