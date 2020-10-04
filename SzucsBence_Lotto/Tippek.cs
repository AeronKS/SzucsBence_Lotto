using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzucsBence_Lotto
{
    class Tippek
    {
        private List<int> tip = new List<int>();

        public List<int> Tip { get => tip; set => tip = value; }

        private int tipSzam;

        public void szamtip()
        {
            int i = 0;
            do
            {
                tipSzam = 0;
                try
                {
                    Console.WriteLine("Válasszon 5 számot 1-től 90-ig!");
                    Console.Write(i+1 + ". szám: ");
                    tipSzam = Int32.Parse(Console.ReadLine());
                    Console.Clear();
                    if (i < 1 && tipSzam < 91)
                    {
                        tip.Add(tipSzam);
                        i++;
                    }
                    else if (i > 0 && tipSzam < 91 && vane(tipSzam) == false)
                    {
                        tip.Add(tipSzam);
                        i++;
                    } else if (tipSzam > 90) {
                        Console.WriteLine("Nincs ilyen lehetőség!\n");
                    } else {
                        Console.WriteLine("Már választott ilyen számot!\n");
                    }
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Nincs ilyen lehetőség!\n");
                }

            } while (i < 5);
        }

        private bool vane(int tipp) 
        {
            bool van = false;
            for (int i = 0; i < tip.Count; i++)
            {
                if (tip[i] == tipp)
                {
                    van = true;
                    break;
                }
            }
            return van;
        }
    }
}
