using System;
using System.Collections.Generic;
using System.Text;

namespace InversionDependenciaG03
{
    public class FormatoExcelService:IFormato
    {
        private ReporteVentasService reporteVentas;
        public FormatoExcelService()
        {
            reporteVentas = new ReporteVentasService();
        }
        
        public string Generar()
        {
            return "Yo lo construyo en formato Excel " + reporteVentas.CrearDocumento();
        }
    }
}
