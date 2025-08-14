namespace CreadorDeReportes
{
    public class ReportePDF
    {
        public string Portada { get; }
        public string TablaMovimientos { get; }
        public string Graficos { get; }
        public string AnalisisTendencias { get; }
        public string PiePagina { get; }

        private ReportePDF(string portada, string tablaMovimientos, string graficos, string analisisTendencias, string piePagina)
        {
            Portada = portada;
            TablaMovimientos = tablaMovimientos;
            Graficos = graficos;
            AnalisisTendencias = analisisTendencias;
            PiePagina = piePagina;
        }

        public void Mostrar(string tipoReporte, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine($"-------- REPORTE {tipoReporte.ToUpper()} --------");
            Console.ResetColor();
            string[] secciones = [Portada, TablaMovimientos, Graficos, AnalisisTendencias, PiePagina];
            foreach (string seccion in secciones)
            {
                if (!string.IsNullOrEmpty(seccion))
                {
                    Console.WriteLine(seccion);
                }
            }
            Console.ForegroundColor = color;
            Console.WriteLine("--------------------------------------------------\n");
            Console.ResetColor();
        }
        public class Builder
        {
            private string _portada;
            private string _tablaMovimientos;
            private string _graficos;
            private string _analisisTendencias;
            private string _piePagina;

            public Builder ConPortada(string cliente, string logotipo)
            {
                _portada = $"Nombre de cliente: {cliente} - logo: {logotipo}";
                return this;
            }

            public Builder ConTablaMovimientos(List<string> movimientos)
            {
                _tablaMovimientos = $"Movimientos: {string.Join(", ", movimientos)}";
                return this;
            }

            public Builder ConGraficos()
            {
                _graficos = "Incluye Gráficos";
                return this;
            }

            public Builder ConAnalisisTendencia()
            {
                _analisisTendencias = "Incluye Analisis de tendencias";
                return this;
            }

            public Builder ConPiePagina(string asesor)
            {
                _piePagina = $"Nombre asesor: {asesor}";
                return this;
            }

            public ReportePDF ConstruirPdf()
            {
                return new ReportePDF(_portada, _tablaMovimientos, _graficos, _analisisTendencias, _piePagina);
            }
        }
    }
}
