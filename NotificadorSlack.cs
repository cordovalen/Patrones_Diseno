namespace NotificacionesClientes
{
    public class NotificadorSlack : NotificadorDecorador
    {
        public NotificadorSlack(INotificador notificador) : base(notificador)
        {
        }

        public override void Enviar(string mensaje)
        {
            base.Enviar(mensaje);
            Console.WriteLine($"Enviando notificación por Slack: {mensaje}");
        }
    }
}
