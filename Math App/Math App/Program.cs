using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_App
{
    class Program
    {
        static void Main(string[] args)
        {
            ConvertFeettoInches();
        }
        static void ConvertFeettoInches()
        {
            try
            {
                Console.WriteLine("Insert number of feet to be converted to inches ");
            var feet = Convert.ToDouble(Console.ReadLine());
            var inches = feet * 12;
            Console.WriteLine($"{feet} ft is equal to {inches} in \n");
            Console.WriteLine("\nWould you like to convert feet to inches again?");
            Console.WriteLine("Enter 1 for yes. Enter 2 to exit.");
            int input = Convert.ToInt32(Console.ReadLine());
           
                if (input == 1)
                {
                    Console.Clear();
                    ConvertFeettoInches();
                }
                else if (input == 2)
                {
                    Environment.Exit(0);
                }
            }
            catch(Exception)
            {
                Console.WriteLine("Please enter number keys");
                Console.WriteLine("Press enter to try again");
                Console.ReadLine();
                Console.Clear();
                ConvertFeettoInches();
            }
        }
    }
}
