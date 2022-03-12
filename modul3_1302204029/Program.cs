using System;

namespace modul3_1302204029
{
    class Program
    {
        static void Main(string[] args)
        {
            KodeBuah obj1 = new KodeBuah();

            KodeBuah.NamaBuah inputNamaBuah = KodeBuah.NamaBuah.Aprikot;
            Console.WriteLine(obj1.getKodeBuah(inputNamaBuah));
        }
    }
}