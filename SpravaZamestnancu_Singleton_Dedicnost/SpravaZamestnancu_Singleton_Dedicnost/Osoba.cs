using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace SpravaZamestnancu_Singleton_Dedicnost
{
    internal class Osoba
    {
        protected string jmeno { get; private set; }
        protected string prijmeni { get; private set; }
        protected int vek { get; private set; }
        protected string uid { get; set; }

        public Osoba(string jmeno, string prijmeni , int vek)
        {
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
            uid = VygenerujUID();
            this.vek = vek;
        }
        private string VygenerujUID()
        {
            Random rnd = new Random();
            string uid = "";
            for (int i = 0; i < 10; i++)
            {
                uid += rnd.Next(0, 10).ToString();
            }
            return uid;
        }
        public virtual void VypisInformace() {
            Console.WriteLine($"{jmeno} {prijmeni} s vekem {vek} uid {uid}");
        }
    }
}
