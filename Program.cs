using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CARPIM_TABLOSU
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string satir = string.Empty;
            for (int i = 1; i <11; i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    satir = satir + $"{j} x {i} = {j*i}    ";
                }
                Console.WriteLine(satir);
                satir = string.Empty;
            }
        }
    }
}
