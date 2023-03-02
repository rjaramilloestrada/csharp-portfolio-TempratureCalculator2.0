using System;
using System.Collections.Concurrent;
using System.Xml;

namespace IfStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the current temperature: ");
            string userTemperature = Console.ReadLine();
            int numTemp;
            int userNumber;
            bool userEnteredNumber = int.TryParse(userTemperature, out userNumber);

            if (userEnteredNumber)
            {
                numTemp = userNumber;
            }

            else
            {
                numTemp = 0;
                Console.WriteLine("The value entered was not a number. Temperature set to 0.");
            }

            if (userNumber < 10)
            {
                Console.WriteLine("Take a coat!");

            } 
            
            else if (userNumber == 10)
            {

                Console.WriteLine("Just go with a long sleeve");

            }
            
            else
            {
                Console.WriteLine("It's hot outside!");
            }

            Console.Read();
        }
    }
}
