using System;

namespace SecurityDemo
{
    public class DatabaseConnection
    {
        public void ConnectToDatabase()
        {
            // VULNERABILITY: Hardcoded credentials
            string dbPassword = "SuperSecretPassword123!"; 
            Console.WriteLine("Connecting with password: " + dbPassword);
        }
    }
}
