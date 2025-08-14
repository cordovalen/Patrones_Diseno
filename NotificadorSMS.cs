namespace NotificacionesClientes
{
    public class NotificadorSMS : NotificadorDecorador
    {
        public NotificadorSMS(INotificador notificador) : base(notificador)
        {
        }

        public override void Enviar(string mensaje)
        {
            base.Enviar(mensaje);
            Console.WriteLine($"Enviando notificación por SMS: {mensaje}");
        }
    }
}
