using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_task
{
    internal class PDF : IPrintable
    {
        public string Print()
        {
            return "PDF Cap edildi";
        }
    }
}
