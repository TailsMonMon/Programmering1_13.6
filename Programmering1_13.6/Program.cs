using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmering1_13._6 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Vad är tempraturen i Östersund? ");
            String östersundString = Console.ReadLine();
            Double östersundTemp = Convert.ToDouble(östersundString);

            Console.Write("Vad är tempraturen i Åmål? ");
            String åmålString = Console.ReadLine();
            Double åmålTemp = Convert.ToDouble(åmålString);

            if(åmålTemp > östersundTemp) {
                Console.WriteLine("Det är kallast i Östersund!");
            }
            else if(åmålTemp == östersundTemp) {
                Console.WriteLine("Det är lika kallt!");
            }
            else {
                Console.WriteLine("Det är kallast i Åmål!");
            }

            Console.ReadKey();
        }
    }
}
