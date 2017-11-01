using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class MojaKlasa
    {
        // TODO:010 Dodati privatno polje (podatkovni član) "broj" tipa int i dodijeliti mu vrijednost 5


        // TODO:011 U metodu IspišiČlan dodati naredbu koja će ispisati podatkovni član "broj".
        public void IspišiČlan()
        {

        }
    }


    struct MojaStruktura
    {
        // TODO:012 Dodati privatno polje (podatkovni član) "tekst" tipa string i dodijeliti mu vrijednost "MojaStruktura"


        // TODO:013 U metodu IspišiČlan dodati naredbu koja će ispisati podatkovni član "tekst".
        public void IspišiČlan()
        {

        }
    }


    public class DefinicijaTipa
    {
        public static void IspišiČlanKlase()
        {
            // TODO:014 Inicijalizirati objekt tipa MojaKlasa i pozvati njegovu metodu IspišiČlan

        }

        public static void IspišiČlanStrukture()
        {
            // TODO:015 Inicijalizirati objekt tipa MojaStruktura i pozvati njegovu metodu IspišiČlan koja treba ispisati "MojaStruktura".

        }

        static void Main(string[] args)
        {
            IspišiČlanKlase();

            IspišiČlanStrukture();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
