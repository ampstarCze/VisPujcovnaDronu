using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer.Object;

namespace Pujcovna_dronu
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
          //  initFirestore();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu());
        }

        static async void initFirestore()
        {
            PrihlasenyZakaznik zakaznik = new PrihlasenyZakaznik
            {
                jmeno = "Franta",
                prijmeni = "Podkova",
                datumNarozeni = new DateTime(1992, 4, 5),
                adresa = "Navsi 92",
                email = "PodkovaFr@gmail.com",
                telefon = "773923153",
                pokutovan = true
            };
            await zakaznik.Pridat();

            zakaznik.jmeno = "Pavel";
            zakaznik.prijmeni = "Kocur";
            zakaznik.datumNarozeni = new DateTime(1993, 8, 6);
            zakaznik.adresa = "Navsi 1464";
            zakaznik.email = "houfnicecze@gmail.com";
            zakaznik.telefon = "773921862";
            zakaznik.pokutovan = true;
            await zakaznik.Pridat();

            zakaznik.jmeno = "Jan";
            zakaznik.prijmeni = "Novak";
            zakaznik.datumNarozeni = new DateTime(1998, 8, 14);
            zakaznik.adresa = "Milikov 234";
            zakaznik.email = "user@user.cz";
            zakaznik.telefon = "673467895";
            zakaznik.pokutovan = false;
            await zakaznik.Pridat();


            Hodnoceni hodnoceni = new Hodnoceni
            {
                idDron = 1,
                jmenoZakaznika = "Franta Podkova",
                datum = DateTime.Today,
                hodnoceni = 8,
                poznamka = "Doporučuji"
            };
            await hodnoceni.Pridat();

            hodnoceni = new Hodnoceni
            {
                idDron = 3,
                jmenoZakaznika = "Jan Novak",
                datum = DateTime.Today,
                hodnoceni = 6,
                poznamka = "První let super, pak mě lehce zlobila baterka."
            };
            await hodnoceni.Pridat();

            hodnoceni = new Hodnoceni
            {
                idDron = 2,
                jmenoZakaznika = "Jan Novak",
                datum = DateTime.Today,
                hodnoceni = 9,
                poznamka = "Super dron"
            };
            await hodnoceni.Pridat();

            hodnoceni = new Hodnoceni
            {
                idDron = 2,
                jmenoZakaznika = "Pavel Kocur",
                datum = DateTime.Today,
                hodnoceni = 5,
                poznamka = "Lítal jsem lepší"
            };
            await hodnoceni.Pridat();

            Vypujcka vypujcka = new Vypujcka
            {
                idZakaznika = 1,
                idDron = 1,
                datumVypujceni = new DateTime(2020, 8, 14),
                datumVraceni = new DateTime(2020, 8, 25),
                cenaDen = 200,
                zaloha = 2000,
                stavVypujcky = "Vráceno"
            };
            await vypujcka.Pridat();

            vypujcka = new Vypujcka
            {
                idZakaznika = 3,
                idDron = 3,
                datumVypujceni = new DateTime(2020, 10, 12),
                datumVraceni = new DateTime(2020, 10, 15),
                cenaDen = 250,
                zaloha = 2200,
                stavVypujcky = "Vráceno"
            };
            await vypujcka.Pridat();

            vypujcka = new Vypujcka
            {
                idZakaznika = 3,
                idDron = 2,
                datumVypujceni = new DateTime(2020, 11, 27),
                datumVraceni = new DateTime(2020, 11, 30),
                cenaDen = 150,
                zaloha = 1500,
                stavVypujcky = "Vráceno"
            };
            await vypujcka.Pridat();

            vypujcka = new Vypujcka
            {
                idZakaznika = 2,
                idDron = 2,
                datumVypujceni = new DateTime(2020, 9, 08),
                datumVraceni = new DateTime(2020, 09, 13),
                cenaDen = 150,
                zaloha = 1500,
                stavVypujcky = "Vráceno"
            };
            await vypujcka.Pridat();

            vypujcka = new Vypujcka
            {
                idZakaznika = 1,
                idDron = 3,
                datumVypujceni = new DateTime(2020, 12, 12),
                cenaDen = 250,
                zaloha = 2200,
                stavVypujcky = "Vypůjčeno"
            };
            await vypujcka.Pridat();

            vypujcka = new Vypujcka
            {
                idZakaznika = 2,
                idDron = 5,
                datumVypujceni = new DateTime(2020, 12, 08),
                cenaDen = 500,
                zaloha = 4800,
                stavVypujcky = "Vypůjčeno"
            };
            await vypujcka.Pridat();

        }
    }
}
