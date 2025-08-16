// See https://aka.ms/new-console-template for more information

using ExploradorArchivos;

// Creamos la estructura de carpetas
Carpeta carpetaRaiz = new("Mis Documentos");
Carpeta subCarpeta1 = new("Imagenes");
Carpeta subCarpeta2 = new("Videos");
Carpeta subCarpeta3 = new("Informes");
Carpeta screenShoots = new("ScreenShot");

// Agregamos archivos y subcarpetas
subCarpeta1.Agregar(new Archivo("Paseo.png", 4096));
subCarpeta1.Agregar(new Archivo("Navidad.png", 8192));
subCarpeta1.Agregar(new Archivo("Mascotas.jpg", 2048));
subCarpeta1.Agregar(new Carpeta("Backup"));

screenShoots.Agregar(new Archivo("ss_20250816.jpg", 2048));
screenShoots.Agregar(new Archivo("ss_20250413.jpg", 2048));
screenShoots.Agregar(new Archivo("ss_20250328.jpg", 2048));
subCarpeta1.Agregar(screenShoots);

subCarpeta2.Agregar(new Archivo("Video_surf", 1080));
subCarpeta2.Agregar(new Carpeta("ReelsIG"));

subCarpeta3.Agregar(new Archivo("Presupuesto.xlsx", 2048));
subCarpeta3.Agregar(new Archivo("Informe_Anual.docx", 1024));

carpetaRaiz.Agregar(new Archivo("Itinerario_Paseo.docx", 1024));
carpetaRaiz.Agregar(subCarpeta1);
carpetaRaiz.Agregar(subCarpeta2);
carpetaRaiz.Agregar(subCarpeta3);

// Ahora el cliente puede interactuar con todo el sistema de forma uniforme
Console.WriteLine("--- Estructura de la carpeta ---");
carpetaRaiz.Mostrar(0);

// Operación uniforme para obtener el tamaño total
Console.WriteLine("\n--- Tamaño Total ---");
long tamanoTotal = carpetaRaiz.ObtenerTamano();
Console.WriteLine($"El tamaño de '{carpetaRaiz.Nombre}' es: {tamanoTotal} bytes.");

// Podemos hacer lo mismo para cualquier subcarpeta, sin cambiar el código
Console.WriteLine("\n--- Tamaño de 'Imagenes' ---");
long tamanoInformes = subCarpeta1.ObtenerTamano();
Console.WriteLine($"El tamaño de '{subCarpeta1.Nombre}' es: {tamanoInformes} bytes.");


