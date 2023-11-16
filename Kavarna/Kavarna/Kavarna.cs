using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Kavarna
{
    internal class Kavarna : IBeverage
    {
        List<IBeverage> beverages = new List<IBeverage>();

        Dictionary<Kava, float> dict_allCoffees = new Dictionary<Kava, float>();
        string nazevKavarny;
        
        public Kavarna(string nazev)
        {
            nazevKavarny = nazev;
            AllCoffees();
        }

        public extra additional { get; set; }

        void AllCoffees()
        {
            dict_allCoffees.Add(new Kava("Americano L", typ.zrnková, zemePuvodu.Guatemala, false), 139.0f);
            dict_allCoffees.Add(new Kava("Flat White M",typ.zrnková, zemePuvodu.Guatemala, true), 149.0f);
            dict_allCoffees.Add(new Kava("Nescafé", typ.instantní, zemePuvodu.Honduras, true), 89.0f);
            dict_allCoffees.Add(new Kava("Nescafé s mlékem", typ.zrnková, zemePuvodu.Honduras, false), 79.0f);
        }
        public void addBeverage(IBeverage beverage)
        {
            beverages.Add(beverage);
        }
        public void getAllInformation() {
            foreach (var item in beverages)
            {
                Kavarna kavarna = (Kavarna)item;
                Console.WriteLine($"{kavarna.nazevKavarny}\n");
                foreach (var coffee in dict_allCoffees)
                {
                    Console.WriteLine($"Káva: {coffee.Key.nazevKavy} | cena: {coffee.Value} Kč");
                }
                Console.WriteLine();
            }
        }
    }
}
