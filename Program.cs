using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akademija_Sitecore_Lipeikaite_Vytaute_Tik_Metodai
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        // grazina daugiausiai is eiles pasikartojanciu raidziu skaiciu tekste
        static int DaugiausiaiIsEilesPasikartojanciuRaidziu(string tekstas)
        {
            int kiekis = 1; // daugiausiai pasikartojanciu raidziu is eiles kiekis
            int pap_kiekis = 0; // papildomas kiekis skaiciavimams
            string pirma_raide = ""; // pirmoji teksto raide

            while (tekstas.Length > 0)
            {
                pirma_raide = tekstas.Substring(0, 1);
                tekstas = tekstas.Remove(0, 1);

                pap_kiekis++;
                if (pap_kiekis > kiekis)
                    kiekis = pap_kiekis;

                if (tekstas.Length != 0)
                    if (pirma_raide != tekstas.Substring(0, 1))
                        pap_kiekis = 0;
            }

            return kiekis;
        }

        static string[] TekstaiSuDaugiausiaiPasikartojimu(string[] Tekstai, int kiek_f, ref int kiek2)
        {
            string[] TekstaiSuPasikartojimais = new string[Cn]; // tekstu masyvas
            kiek2 = 0;

            // isrenkamas didziausias pasikartojimu kiekis
            int max_pasikartojimai = 0;
            for (int i = 0; i < kiek_f; i++)
            {
                int pasikartojimai = DaugiausiaiIsEilesPasikartojanciuRaidziu(Tekstai[i]);
                if (pasikartojimai > max_pasikartojimai)
                    max_pasikartojimai = pasikartojimai;
            }

            for (int i = 0; i < kiek_f; i++)
            {
                int pasikartojimai = DaugiausiaiIsEilesPasikartojanciuRaidziu(Tekstai[i]);
                if (pasikartojimai == max_pasikartojimai)
                {
                    TekstaiSuPasikartojimais[kiek2++] = Tekstai[i];
                }
            }

            return TekstaiSuPasikartojimais;
        }
    }
}
