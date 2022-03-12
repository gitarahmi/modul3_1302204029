using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul3_1302204029
{
    public class PosisiKarakterGame
    {
        public enum Posisi
        {
            Berdiri,
            Jongkok,
            Terbang,
            Tengkurap
        };
        public enum Aksi
        {
            TombolW,
            TombolX,
            TombolY
        }
        public class Transisi
        {
            public Posisi StateAwal;
            public Posisi StateAkhir;
            public Aksi Trigger;

            public Transisi(Posisi awal, Posisi akhir, Aksi yangDilakukan)
            {
                StateAwal = awal;
                StateAkhir = akhir;
                Trigger = yangDilakukan;
            }
        }
        Transisi[] listPerpindahanState =
        {
            new Transisi(Posisi.Terbang, Posisi.Jongkok, Aksi.TombolX),
            new Transisi(Posisi.Berdiri, Posisi.Terbang, Aksi.TombolW)
        };
        public Posisi StateSaatIni = Posisi.Berdiri;

        public Posisi GetPosisiAkhir(Posisi awal, Aksi yangDilakukan)
        {
            Posisi posisiAkhir = awal;

            for (int i=0; i < listPerpindahanState.Length; i++)
            {
                Posisi stateAwal = listPerpindahanState[i].StateAwal;
                Aksi triggerState = listPerpindahanState[i].Trigger;

                if(stateAwal == awal && triggerState == yangDilakukan)
                {
                    posisiAkhir = listPerpindahanState[i].StateAkhir;
                }
                return posisiAkhir;
            }
            public void AksiYangDilakukan(Aksi yangDilakukan)
            {
                Posisi stateBerikutnya = GetPosisiAkhir(StateSaatIni, yangDilakukan);
                StateSaatIni = stateBerikutnya;

                Console.WriteLine("State saat ini adalah: " + StateSaatIni);
            }
        }
    }
}
