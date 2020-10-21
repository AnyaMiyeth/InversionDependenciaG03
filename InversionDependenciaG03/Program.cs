using System;

namespace InversionDependenciaG03
{
    class Program
    {
        static void Main(string[] args)
        {
            //IFormato formato = new FormatoExcelService();.
            IFormato formato = new FormatoPDFService();
            IFormato formato2 = new FormatoWordService();
            ImpresionService impresion = new ImpresionService(formato2);
            Console.WriteLine(impresion.Imprimir());
            Console.ReadKey();

        }
    }
}
