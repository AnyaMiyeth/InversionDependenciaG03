using System;
using System.Collections.Generic;
using System.Text;

namespace InversionDependenciaG03
{
   public class FormatoWordService : IFormato
    {
        private ReporteVentasService reporteVentas;
        public FormatoWordService()
        {
            reporteVentas = new ReporteVentasService();
        }
        public string Generar()
        {
            return "Yo lo construyo en formato Word " + reporteVentas.CrearDocumento();
        }
    }
}
