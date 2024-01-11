namespace SpravaZamestnancu_Singleton_Dedicnost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zamestnanec Karel = new Zamestnanec("Karel", "Hustý", 68);
            Zamestnanec Pepa = new Zamestnanec("Pepa", "Novík", 19);
            Zamestnanec Frantisek = new Zamestnanec("Frantisek", "Lupa", 12);
            Zamestnanec Ladislav = new Zamestnanec("Ladislav", "Krkolomný", 18);
            Zamestnanec Dominik = new Zamestnanec("Dominik", "Nový", 18);
            Zamestnanec Pavlina = new Zamestnanec("Pavlina", "Suchánková", 38);
            Zamestnanec Karolina = new Zamestnanec("Karolína", "Doudová", 27);

            Manazer Leos = new Manazer("Leoš", "Nežerný", 17);
            Leos.PridejPodrizeneho(Karel);
            Leos.PridejPodrizeneho(Pepa);
            Leos.PridejPodrizeneho(Frantisek);
            Leos.PridejPodrizeneho(Ladislav);
            Leos.PridejPodrizeneho(Dominik);

            Manazer Jana = new Manazer("Jana", "Králová", 27);
            Jana.PridejPodrizeneho(Pavlina);
            Jana.PridejPodrizeneho(Karolina);

            SpravaZamestnancu.spravce.PridatZamestnance(Karel);
            SpravaZamestnancu.spravce.PridatZamestnance(Pepa);
            SpravaZamestnancu.spravce.PridatZamestnance(Frantisek);
            SpravaZamestnancu.spravce.PridatZamestnance(Ladislav);
            SpravaZamestnancu.spravce.PridatZamestnance(Dominik);
            SpravaZamestnancu.spravce.PridatZamestnance(Pavlina);
            SpravaZamestnancu.spravce.PridatZamestnance(Karolina);
            SpravaZamestnancu.spravce.PridatZamestnance(Leos);
            SpravaZamestnancu.spravce.PridatZamestnance(Jana);

            SpravaZamestnancu.spravce.VypisInformace();
        }
    }
}