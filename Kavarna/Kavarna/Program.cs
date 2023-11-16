namespace Kavarna
{
    class Program {

        static void Main(string[] args) { 

            Kavarna kavarna = new Kavarna("Kavárna u Jana");
            Kavarna kavarna2 = new Kavarna("Kavárna u Pana");

            Kavarna vsechnyKavarny = new Kavarna("all");

            vsechnyKavarny.addBeverage(kavarna);
            vsechnyKavarny.addBeverage(kavarna2);

            vsechnyKavarny.getAllInformation();

        }
    }
}
