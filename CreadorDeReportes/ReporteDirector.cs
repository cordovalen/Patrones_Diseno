namespace CreadorDeReportes
{
    public class ReporteDirector
    {
        private readonly ReportePDF.Builder _pdfBuilder;

        public ReporteDirector(ReportePDF.Builder pdfBuilder)
        {
            _pdfBuilder = pdfBuilder;
        }

        public void ConstruirReporteBasico(string cliente, string logo, string asesor)
        {
            _pdfBuilder.ConPortada(cliente, logo);
            _pdfBuilder.ConPiePagina(asesor);
        }

        public void ConstruirReporteCompleto(string cliente, string logo, string asesor, List<string> movimientos)
        {
            _pdfBuilder.ConPortada(cliente, logo);
            _pdfBuilder.ConGraficos();
            _pdfBuilder.ConTablaMovimientos(movimientos);
            _pdfBuilder.ConAnalisisTendencia();
            _pdfBuilder.ConPiePagina(asesor);
        }

        public void ConstruirReporteCondicional(bool datosSuficientes, string cliente, string logo, string asesor, List<string> movimientos)
        {
            _pdfBuilder.ConPortada(cliente, logo);
            _pdfBuilder.ConGraficos();
            _pdfBuilder.ConTablaMovimientos(movimientos);
            if (datosSuficientes)
            {
                _pdfBuilder.ConAnalisisTendencia();
            }

            _pdfBuilder.ConPiePagina(asesor);
        }
    }
}
