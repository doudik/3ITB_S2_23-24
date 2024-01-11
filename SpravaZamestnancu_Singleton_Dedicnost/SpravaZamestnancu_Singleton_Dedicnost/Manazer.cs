using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpravaZamestnancu_Singleton_Dedicnost
{
    internal class Manazer : Osoba
    {
        List<Zamestnanec> seznamPodrizenych = new List<Zamestnanec>();

        public Manazer(string jmeno, string prijmeni, int vek) : base(jmeno, prijmeni, vek)
        {
            uid = "man_" + uid;
        }
        public void PridejPodrizeneho(Zamestnanec zam) { 
            seznamPodrizenych.Add(zam);
        }
        public void OdeberPodrizeneho(Zamestnanec zam)
        {
            seznamPodrizenych.Remove(zam);
        }
        public override void VypisInformace()
        {
            Console.Write("\nManažer ");
            base.VypisInformace();
            foreach (Zamestnanec item in seznamPodrizenych)
            {
                item.VypisInformace();
            }
        }
    }
}
