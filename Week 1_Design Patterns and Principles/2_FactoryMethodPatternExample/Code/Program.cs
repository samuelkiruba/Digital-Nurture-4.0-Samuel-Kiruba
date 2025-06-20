using System;
class PDFDocument : DocumentFactory
{
    public override void CreateDocument()
    {
        Console.WriteLine("PDF Document Created");
    }
}
class WordDocument : DocumentFactory
{
    public override void CreateDocument()
    {
        Console.WriteLine("Word Document Created");
    }
}
class ExcelDocument : DocumentFactory
{
    public override void CreateDocument()
    {
        Console.WriteLine("Excel Document Created");
    }
}
abstract class DocumentFactory
{
    public abstract void CreateDocument();
}
public class FactoryMethodPatternExample
{
    static void Main(string[] args)
    {
        DocumentFactory pdf = new PDFDocument();
        pdf.CreateDocument();
        DocumentFactory word = new WordDocument();
        word.CreateDocument();
        DocumentFactory excel = new ExcelDocument();
        excel.CreateDocument();
    }
}
