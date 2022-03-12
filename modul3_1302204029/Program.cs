using System;

namespace modul3_1302204029
{
    class Program
    {
        // table-driven
        static void Main(string[] args)
        {
            KodeBuah obj1 = new KodeBuah();

            KodeBuah.NamaBuah inputNamaBuah = KodeBuah.NamaBuah.Aprikot;
            Console.WriteLine(obj1.getKodeBuah(inputNamaBuah));



        // state-based
            PosisiKarakterGame objPosisiMhs = new PosisiKarakterGame();
            Console.WriteLine(objPosisiMhs.StateSaatIni);
        }
    }
}