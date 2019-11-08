using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesExtensibility
{
    public class ConsoleLogger : ILogger
    {
        public void LogError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red; //change color of text to red to indicate error
            Console.WriteLine(message);
            
        }

        public void LogInfo(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
        }
    }
}
