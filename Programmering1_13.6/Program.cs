using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmering1_13._6 {
    class Program {
        static void Main(string[] args) {
            List<CityTemperature> cityNameAndTemprature = new List<CityTemperature>();
            Console.WriteLine("=== MENY === \n" +
                              "[L]ägg till temperaturmätning \n" +
                              "[S]kriv ut alla temperaturer samt medeltemeratur \n" +
                              "[A]vsluta");
            do {
                ConsoleKeyInfo menuChoice = Console.ReadKey(true);

                if(menuChoice.Key == ConsoleKey.L) {
                    Console.Write("Ange stad: ");
                    string name = Console.ReadLine();
                    Console.Write("Ange temperatur: ");
                    int temp = Convert.ToInt32(Console.ReadLine());
                    
                    cityNameAndTemprature.Add(new CityTemperature(temp, name));
                }
                else if(menuChoice.Key == ConsoleKey.S) {
                    int totalTemperatures = 0;
                    Console.WriteLine("Följande temperaturer har angets: ");
                    foreach(CityTemperature cityTempValue in cityNameAndTemprature) {
                        Console.Write(cityTempValue.Name + " ");
                        Console.WriteLine(cityTempValue.Temprature);

                        totalTemperatures += cityTempValue.Temprature;
                    }
                    int mediumValue = totalTemperatures / cityNameAndTemprature.Count;
                    Console.WriteLine("Medeltemperaturen är {0} grader", mediumValue);
                }
                else if(menuChoice.Key == ConsoleKey.A) {
                    Console.WriteLine("Tack för denna gången!");
                    break;
                }
                else {
                    Console.WriteLine("=== MENY === \n" +
                              "[L]ägg till temperaturmätning \n" +
                              "[S]kriv ut alla temperaturer samt medeltemeratur \n" +
                              "[A]vsluta");
                }
            } while(true);
            Console.ReadKey();
        }
    }
}
