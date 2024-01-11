using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace SpravaZamestnancu_Singleton_Dedicnost
{
    internal class Zamestnanec : Osoba
    {
        public Zamestnanec(string jmeno, string prijmeni, int vek) : base(jmeno, prijmeni, vek)
        {
            uid = "zam_" + uid;
        }
    }
}
