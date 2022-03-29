using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_task
{
    internal class Excel : IPrintable
    {
        public string Print()
        {
            return "Excel Cap edildi";
        }
    }
}
