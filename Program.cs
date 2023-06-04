using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace pitsiBi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int da = 0;
            string da1 = "-7";
            for (int i = 1007; i > 0 ; i -= 7)
            {
                da = i - 7;
                
                Console.WriteLine(da + da1);
                Thread.Sleep(50);
            }
        }
    }
}
