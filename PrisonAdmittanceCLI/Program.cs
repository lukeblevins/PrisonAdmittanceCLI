
using System.Security.Cryptography;
using MySql.Data.MySqlClient;

namespace PrisonSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {

            MySqlConnection mySqlConnector = new MySqlConnection();

            mySqlConnector.ConnectionString = "server=localhost;user=root;password=12345678;database=PrisonSystem";
            mySqlConnector.Open();

            PopulateDatabase(mySqlConnector);


            if (args.Length == 0)
            {
                Console.WriteLine("Please provide a command.");
                return;
            }
            else if (args[0] == "help")
            {
                Console.WriteLine("Commands:");
                Console.WriteLine("help - Display this list of commands");
                Console.WriteLine("prisons - List all prisons");
                Console.WriteLine("employees - Manage a prison employee");
                Console.WriteLine("inmates - manage a prison inmate");
                Console.WriteLine("facility -  view floorplan details");
                return;
            }
            else if (args[0] == "prisons")
            {
                Prisons(args, mySqlConnector);
            }
            else if (args[0] == "employees")
            {
                Employees(args, mySqlConnector);
            }
            else if (args[0] == "inmates")
            {
                Inmates(args, mySqlConnector);
            }
            else if (args[0] == "facility")
            {
                Facilities(args, mySqlConnector);
            }
            else
            {
                Console.WriteLine("Invalid command. Use 'help' to see a list of commands.");
            }
        }

        private static void PopulateDatabase(MySqlConnection mySqlConnector)
        {
            // Create a new table

            // MySqlCommand createCellsTable = new MySqlCommand("CREATE TABLE IF NOT EXISTS Cells (Id INT PRIMARY KEY, PrisonerCount INT, CellBlockId INT)", mySqlConnector);
            // createCellsTable.ExecuteNonQuery();
            // MySqlCommand createPrisonsTable = new MySqlCommand("CREATE TABLE IF NOT EXISTS Prisons (Id INT PRIMARY KEY, Name VARCHAR(255))", mySqlConnector);
            // createPrisonsTable.ExecuteNonQuery();
            // MySqlCommand cellBlocksTable = new MySqlCommand("CREATE TABLE IF NOT EXISTS CellBlocks (Id INT PRIMARY KEY, CrimeCategory VARCHAR(255), Gender VARCHAR(255), PrisonId INT);");
            // createCellsTable.ExecuteNonQuery();
            // MySqlCommand guardsTable = new MySqlCommand("CREATE TABLE IF NOT EXISTS Guards (Id INT PRIMARY KEY, FirstName VARCHAR(255), LastName VARCHAR(255), Age INT, Gender VARCHAR(255), Race VARCHAR(255));");
            // createCellsTable.ExecuteNonQuery();
            // MySqlCommand wardensTable = new MySqlCommand("CREATE TABLE IF NOT EXISTS Wardens (Id INT PRIMARY KEY, FirstName VARCHAR(255), LastName VARCHAR(255), Age INT, Gender VARCHAR(255), Race VARCHAR(255));");
            // createCellsTable.ExecuteNonQuery();
            // MySqlCommand prisonersTable = new MySqlCommand("CREATE TABLE IF NOT EXISTS Prisoners (Id INT PRIMARY KEY, FirstName VARCHAR(255), LastName VARCHAR(255), Age INT, Gender VARCHAR(255), Race VARCHAR(255), CellId INT);");
            // createCellsTable.ExecuteNonQuery();

            // Insert data into the table
            MySqlScript mySqlScript = new MySqlScript(mySqlConnector, File.ReadAllText("Models/Files/Cells.sql"));
            MySqlScript mySqlScript2 = new MySqlScript(mySqlConnector, File.ReadAllText("Models/Files/Prisons.sql"));
            MySqlScript mySqlScript3 = new MySqlScript(mySqlConnector, File.ReadAllText("Models/Files/CellBlocks.sql"));
            MySqlScript mySqlScript4 = new MySqlScript(mySqlConnector, File.ReadAllText("Models/Files/Guards.sql"));
            MySqlScript mySqlScript5 = new MySqlScript(mySqlConnector, File.ReadAllText("Models/Files/Wardens.sql"));
            MySqlScript mySqlScript6 = new MySqlScript(mySqlConnector, File.ReadAllText("Models/Files/Prisoners.sql"));

            mySqlScript.Execute();
            mySqlScript2.Execute();
            mySqlScript3.Execute();
            mySqlScript4.Execute();
            mySqlScript5.Execute();
            mySqlScript6.Execute();
        }

        private static void Prisons(string[] args, MySqlConnection mySqlConnector)
        {
            if (args[1] == "list")
            {
                // List all prisons
                MySqlCommand listPrisons = new MySqlCommand("SELECT * FROM Prisons", mySqlConnector);
                MySqlDataReader reader = listPrisons.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine($"Id: {reader["Id"]}, Name: {reader["Name"]}");
                }
                reader.Close();
            }
        }

        private static void Employees(string[] args, MySqlConnection mySqlConnector)
        {
            if (args[1] == "list")
            {
                if (args[2] == "guards")
                {
                    // List all guards
                    MySqlCommand listGuards = new MySqlCommand("SELECT * FROM Guards", mySqlConnector);
                    MySqlDataReader reader = listGuards.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine($"GUARD:\t\tId: {reader["Id"]}, FirstName: {reader["FirstName"]}, LastName: {reader["LastName"]}, Age: {reader["Age"]}, Gender: {reader["Gender"]}, Race: {reader["Race"]}");
                    }
                }
                else if (args[2] == "wardens")
                {
                    // List all wardens
                    MySqlCommand listWardens = new MySqlCommand("SELECT * FROM Wardens", mySqlConnector);
                    MySqlDataReader reader = listWardens.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine($"WARDEN:\t\tId: {reader["Id"]}, FirstName: {reader["FirstName"]}, LastName: {reader["LastName"]}, Age: {reader["Age"]}, Gender: {reader["Gender"]}, Race: {reader["Race"]}");
                    }
                }
            }
            else if (args[1] == "add")
            {
                if (args[2] == "guard")
                {
                    // Add a guard
                    MySqlCommand addGuard = new MySqlCommand($"insert into Guards (		Guard_ID,		Guard_FirstName,		Guard_LastName,		Age,		Gender,		Race) -> values (		'{args[3]}',		'{args[4]}',		'{args[5]}',		'{args[6]}',		'{args[7]}',		'{args[8]}'	)", mySqlConnector);

                    addGuard.ExecuteNonQuery();
                    Console.WriteLine("Guard added successfully.");

                }
                else if (args[2] == "warden")
                {
                    // Add a warden
                    MySqlCommand addWarden = new MySqlCommand($"insert into Wardens (		Warden_ID,		Warden_FirstName,		Warden_LastName,		Age, Gender, Race) -> values (		'{args[3]}',		'{args[4]}',		'{args[5]}',		'{args[6]}',		'{args[7]}',		'{args[8]}'	)", mySqlConnector);
                }
            }
            else if (args[1] == "remove")
            {
                if (args[2] == "guard")
                {
                    // Remove a guard
                    MySqlCommand removeGuard = new MySqlCommand($"delete from Guards where Guard_ID = {args[3]}", mySqlConnector);
                    removeGuard.ExecuteNonQuery();
                    Console.WriteLine("Guard removed successfully.");
                }
                else if (args[2] == "warden")
                {
                    // Remove a warden
                    MySqlCommand removeWarden = new MySqlCommand($"delete from Wardens where Warden_ID = {args[3]}", mySqlConnector);
                    removeWarden.ExecuteNonQuery();
                    Console.WriteLine("Warden removed successfully.");
                }
            }
        }
        private static void Inmates(string[] args, MySqlConnection mySqlConnector)
        {
            if (args[1] == "list")
            {

            }
        }

        private static void Facilities(string[] args, MySqlConnection mySqlConnector)
        {
            if (args[1] == "list")
            {

            }
        }
    }
}