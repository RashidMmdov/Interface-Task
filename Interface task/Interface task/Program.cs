using System;

namespace Interface_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Word word = new Word();
            Excel excel = new Excel();
            PDF pdf = new PDF();
            MainPrintFile mainFile = new MainPrintFile(word, excel, pdf);
            Console.WriteLine(mainFile.Word);
            Console.WriteLine(mainFile.Execel);
            Console.WriteLine(mainFile.Pdf);
            //Men 3-u nu de cagirdim hansini isdesenis cagira bilersizzz :)) 
        }
    }
}
