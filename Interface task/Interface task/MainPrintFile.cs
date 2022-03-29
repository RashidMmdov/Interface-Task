using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_task
{
    internal class MainPrintFile 
    {
        public string Word { get; set; }
        public string Execel { get; set; }
        public string Pdf { get; set; }
        public MainPrintFile(Word word,Excel excel,PDF pdf)
        {
            Word = word.Print();
            Execel = excel.Print();
            Pdf = pdf.Print();
        }
        
    }
}
