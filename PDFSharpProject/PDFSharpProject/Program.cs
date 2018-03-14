using System;
using System.Reflection;
using System.IO;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using PdfSharp.Pdf.Advanced;

namespace PDFSharpProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Provide path to a PDF file (or just hit enter to get the default)");
            string path = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(path))
            {
                path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "TestPDF.pdf");
            }

            if (string.IsNullOrWhiteSpace(path)) return;
            TryToFindObject(path);
        }

        private static void TryToFindObject(string pdfPath)
        {
            PdfDocument pdf = PdfReader.Open(pdfPath);
            PdfPage page = pdf.Pages[0];
            PdfDictionary contents = page.Elements.GetDictionary("/Contents");
            if (contents == null) return;

            var items = contents.Elements.Values;
            Console.WriteLine("Here I don't know what to do");

        }
    }
}
