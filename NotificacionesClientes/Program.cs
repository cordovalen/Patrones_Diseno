// See https://aka.ms/new-console-template for more information
using NotificacionesClientes;

Console.WriteLine("-----Notificaciones a clientes usando patrón estructural - Decorator-----");
string mensaje = "¡Pedido completado!";

//Caso de envio notificación por email
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("\n--- Cliente con notificacion solo por email");
Console.ResetColor();
INotificador notificadorEmail = new NotificadorCorreo();
notificadorEmail.Enviar(mensaje);

//Caso de envio notificación por email + SMS
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\n--- Cliente con notificacion por email + SMS");
Console.ResetColor();
INotificador notificadorEmailSMS = new NotificadorCorreo();
notificadorEmailSMS = new NotificadorSMS(notificadorEmailSMS);
notificadorEmailSMS.Enviar(mensaje);

//Caso de envio notificación por todos lo canales
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("\n--- Cliente con notificacion por email + SMS + WhatsApp + Slack ");
Console.ResetColor();
INotificador notificadorAll = new NotificadorCorreo();
notificadorAll = new NotificadorSMS(notificadorAll);
notificadorAll = new NotificadorWhatsApp(notificadorAll);
notificadorAll = new NotificadorSlack(notificadorAll);
notificadorAll.Enviar(mensaje);