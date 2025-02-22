using System;

namespace PP_22_02_25_NUnit
{
    public class DatabaseConnection
    {
        public bool IsConnected { get; private set; }

        public void Connect()
        {
            IsConnected = true;
            Console.WriteLine("Database connected.");
        }

        public void Disconnect()
        {
            IsConnected = false;
            Console.WriteLine("Database disconnected.");
        }
    }
}
