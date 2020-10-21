using System;
using System.Collections.Generic;
using System.Text;

namespace InversionDependenciaG03
{
   public class FormatoPDFService:IFormato
    {
        private ReporteVentasService reporteVentas;
        private ReporteCompraService reporteCompra;
         public FormatoPDFService()
        {
            reporteVentas = new ReporteVentasService();
            reporteCompra = new ReporteCompraService();
        }
         public string Generar()
        {
            return "Yo lo construyo en formato PDF " + reporteVentas.CrearDocumento();
        }
    }
}
