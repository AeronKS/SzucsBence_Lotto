using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzucsBence_Lotto
{
    class Program
    {
        static void Main(string[] args)
        {
            var Beolv = new Beolv();
            var tip = new Tippek();
            Beolv.Beolvas();
            tip.szamtip();



            Console.ReadKey();
        }
    }
}
