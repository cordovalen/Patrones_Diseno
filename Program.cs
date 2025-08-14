// See https://aka.ms/new-console-template for more information
using NotificacionesClientes;

Console.WriteLine("-----Notificaciones a clientes usando patrón estructural - Decorator-----");
string mensaje = "Pedido completado!";

//Caso de envio notificación por email
Console.WriteLine("\n--- Cliente con notificacion solo por email");
INotificador notificadorEmail = new NotificadorCorreo();
notificadorEmail.Enviar(mensaje);

//Caso de envio notificación por email + SMS
Console.WriteLine("\n--- Cliente con notificacion por email + SMS");
INotificador notificadorEmailSMS = new NotificadorCorreo();
notificadorEmailSMS = new NotificadorSMS(notificadorEmailSMS);
notificadorEmailSMS.Enviar(mensaje);

//Caso de envio notificación por todos lo canales
Console.WriteLine("\n--- Cliente con notificacion por email + SMS + WhatsApp + Slack");
INotificador notificadorAll = new NotificadorCorreo();
notificadorAll = new NotificadorSMS(notificadorAll);
notificadorAll = new NotificadorWhatsApp(notificadorAll);
notificadorAll = new NotificadorSlack(notificadorAll);
notificadorAll.Enviar(mensaje);