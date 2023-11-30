using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using Org.BouncyCastle.Asn1.Mozilla;

namespace ConnectionManagerSingleton
{
    internal sealed class ConnectionManager
    {
        static ConnectionManager manager { get; set; } = new ConnectionManager();
        public static ConnectionManager Manager { get { return manager; }}
        MySqlConnection connection;

        private ConnectionManager(){}

        public void Connect()
        {
            string sql = "server=localhost;uid=root;pwd=;database=zaci3ITB";
            connection = new MySqlConnection(sql);
            try
            {
                Console.WriteLine("Connecting...");
                connection.Open();
                Console.WriteLine("Connected!");
            }
            catch (Exception)
            {

                throw;
            }
        }   
        public void Disconnect() {
            try
            {
                connection.Close();
                Console.WriteLine("Disconnected");
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void ShowAllData() { 
            string sql = "SELECT * FROM zaci";
            MySqlCommand command = new MySqlCommand(sql, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                Console.WriteLine($"ID: {reader[0]} | Jméno: {reader[1]} | Příjmení: {reader[2]}");
            }
        }
        public void AddRow(string? jmeno = null, string? prijmeni = null) {
            string sql;
            if (jmeno == null || prijmeni == null)
            {
                Console.WriteLine("Zadejte jméno a příjmení");
                return;
            }
            else if (jmeno == null)
            {
                sql = $"INSERT INTO zaci VALUES (NULL, NULL, '{prijmeni}')";
                Execute(sql);
                return;
            }
            else if (prijmeni == null)
            {
                sql = $"INSERT INTO zaci VALUES (NULL, '{jmeno}', NULL)";
                Execute(sql);
                return;
            }
            else { 
                sql = $"INSERT INTO zaci VALUES (NULL, '{jmeno}', '{prijmeni}')";
                Execute(sql);
            }
        }
        public void DeleteRow(string jmeno, string prijmeni) { 
            string sql = $"DELETE FROM zaci WHERE jmeno = '{jmeno}' AND prijmeni = '{prijmeni}'";
            Execute(sql);
        }
        private void Execute(string sql) {
            MySqlCommand command = new MySqlCommand(sql, connection);
            command.ExecuteNonQuery();
        }
    }
}
