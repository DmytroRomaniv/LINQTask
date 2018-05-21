using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQTask
{
    class Program
    {
        static void Main(string[] args)
        {
            FileReader.DoGroup1("dataGroup1.txt");
            Group2FileReader.DoGroup2("dataGroup2.txt");
        }
    }
}
