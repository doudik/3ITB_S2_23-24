using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Kavarna
{
    internal class Kava : IBeverage
    {
        public string nazevKavy { get; private set; }
        typ typ_kavy;
        zemePuvodu kava_zemePuvodu;
        bool mleko;
        float cena;
        
        public Kava(string n, typ t, zemePuvodu z, bool m) {
            typ_kavy = t;
            kava_zemePuvodu = z;
            mleko = m;
            nazevKavy = n;
        }

        public extra additional { get; set; }

        public void getAllInformation()
        {
            Console.WriteLine(additional);
        }
    }

    enum typ{
        zrnková,
        mletá,
        instantní,
        kapsle
    }
    enum zemePuvodu
    {
        Brazílie,
        Kolumbie,
        Etiopie,
        Guatemala,
        Honduras,
        Indie,
        Indonésie,
        Jamajka,
        Kostarika,
        Mexiko,
        Nikaragua,
        Peru,
        Salvador,
        Tanzánie,
        Vietnam
    }
    enum extra {
        sirup,
        rum,
        liker,
        toping
    }
}
