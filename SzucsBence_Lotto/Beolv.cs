using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SzucsBence_Lotto
{
    class Beolv
    {
        private List<Beolv> huzasok = new List<Beolv>();

        private int szam1;
        private int szam2;
        private int szam3;
        private int szam4;
        private int szam5;

        internal List<Beolv> Huzasok { get => huzasok; set => huzasok = value; }

        public void Beolvas()
        {
            StreamReader sr = new StreamReader("otos.csv");
            while (!sr.EndOfStream)
            {
                string[] temp = sr.ReadLine().Split(';');
                Beolv szamok = new Beolv
                {
                    szam1 = Convert.ToInt32(temp[11]),
                    szam2 = Convert.ToInt32(temp[12]),
                    szam3 = Convert.ToInt32(temp[13]),
                    szam4 = Convert.ToInt32(temp[14]),
                    szam5 = Convert.ToInt32(temp[15]),
                };

                huzasok.Add(szamok);
            }
            sr.Close();
        }

        public override string ToString()
        {
            return szam1 + "\t" + szam2 + "\t" + szam3 + "\t" + szam4 + "\t" + szam5;
        }
    }
}