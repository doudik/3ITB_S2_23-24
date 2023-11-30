namespace ConnectionManagerSingleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConnectionManager.Manager.Connect();
            ConnectionManager.Manager.AddRow("Petr", "Novák"); 
            ConnectionManager.Manager.AddRow(prijmeni : "novák");
            ConnectionManager.Manager.ShowAllData();
            ConnectionManager.Manager.Disconnect();
        }
    }
}