using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpravaZamestnancu_Singleton_Dedicnost
{
    internal sealed class SpravaZamestnancu
    {
        List<Osoba> zamestnanci { get; set; } = new List<Osoba>();

        static SpravaZamestnancu instance;
        public static SpravaZamestnancu spravce { 
            get {
                if (instance == null)
                {
                    instance = new SpravaZamestnancu();
                }
                return instance;
            } 
        }
        private SpravaZamestnancu() { }
        public void PridatZamestnance(Osoba zamestnanec)
        {
            zamestnanci.Add(zamestnanec);
        }
        public void OdebratZamestnance(Osoba zamestnanec)
        {
            zamestnanci.Remove(zamestnanec);
        }
        public void VypisInformace()
        {
            foreach (Osoba item in zamestnanci)
            {
                item.VypisInformace();
            }
        }
    }
}
