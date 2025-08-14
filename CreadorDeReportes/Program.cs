// See https://aka.ms/new-console-template for more information
using CreadorDeReportes;

Console.WriteLine("-----Construir reporte pdf usando patrón creacional - Builder-----\n");

//Caso 1: Construir reporte basico
ReportePDF.Builder builderBasico = new();
ReporteDirector directorBasico = new(builderBasico);
directorBasico.ConstruirReporteBasico("Juan Pérez", "XXXX", "Pedro Pérez");
ReportePDF reporteBasico = builderBasico.ConstruirPdf();
reporteBasico.Mostrar("Básico", ConsoleColor.Blue);


//Caso 2: Construir reporte Completo
ReportePDF.Builder builderCompleto = new();
ReporteDirector directorCompleto = new(builderCompleto);
directorCompleto.ConstruirReporteCompleto("Juan Pérez", "AAAA", "Pedro Pérez", ["mov1", "mov2", "mov3", "mov4"]);
ReportePDF reporteCompleto = builderCompleto.ConstruirPdf();
reporteCompleto.Mostrar("Completo", ConsoleColor.Magenta);

//Caso 3: Construir reporte con Condicion dinamica sin Datos suficientes
bool datosSuficientes = false;
ReportePDF.Builder builderDatosInsuficientes = new();
ReporteDirector directorDatosInsuficientes = new(builderDatosInsuficientes);
directorDatosInsuficientes.ConstruirReporteCondicional(datosSuficientes, "Juan Pérez", "AAAA", "Pedro Pérez", ["mov1", "mov2", "mov3", "mov4"]);
ReportePDF reporteDatosInsuficientes = builderDatosInsuficientes.ConstruirPdf();
reporteDatosInsuficientes.Mostrar("Sin datos suficientes", ConsoleColor.DarkGreen);

//Caso 3: Construir reporte con Condicion dinamica con Datos suficientes
datosSuficientes = true;
ReportePDF.Builder builderDatosSuficientes = new();
ReporteDirector directorDatosSuficientes = new(builderDatosSuficientes);
directorDatosSuficientes.ConstruirReporteCondicional(datosSuficientes, "Juan Pérez", "AAAA", "Pedro Pérez", ["mov1", "mov2", "mov3", "mov4"]);
ReportePDF reporteDatosSuficientes = builderDatosSuficientes.ConstruirPdf();
reporteDatosSuficientes.Mostrar("Con datos suficientes", ConsoleColor.Red);




