using System;

namespace DocumentManagement
{
    
    abstract class Document
    {
        public abstract void PrintContent();

        public void ShowDocumentType(string type)
        {
            Console.WriteLine($"Document Type: {type}");
        }
    }

    
    class WordDocument : Document
    {
        public override void PrintContent()
        {
            Console.WriteLine("Printing Word document");
        }
    }

    class PDFDocument : Document
    {
        public override void PrintContent()
        {
            Console.WriteLine("Printing PDF document");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            Document word = new WordDocument();
            Document pdf = new PDFDocument();

            word.ShowDocumentType("Word");
            word.PrintContent();

            pdf.ShowDocumentType("PDF");
            pdf.PrintContent();
        }
    }
}