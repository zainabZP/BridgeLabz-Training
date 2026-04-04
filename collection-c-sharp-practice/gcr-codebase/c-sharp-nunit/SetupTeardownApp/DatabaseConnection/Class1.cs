using System;

namespace DatabaseConnectionApp
{
    public class DatabaseConnection
    {
        public bool IsConnected { get; private set; } = false;

        // Connect method
        public void Connect()
        {
            IsConnected = true;
            Console.WriteLine("Database connected.");
        }

        // Disconnect method
        public void Disconnect()
        {
            IsConnected = false;
            Console.WriteLine("Database disconnected.");
        }
    }
}
