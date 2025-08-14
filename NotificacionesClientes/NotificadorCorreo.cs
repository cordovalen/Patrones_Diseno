namespace NotificacionesClientes
{
    public class NotificadorCorreo : INotificador
    {
        public void Enviar(string mensaje)
        {
            Console.WriteLine($"Enviando notificacion por Email: {mensaje}");
        }
    }
}
