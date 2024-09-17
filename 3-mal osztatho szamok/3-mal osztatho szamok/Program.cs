using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_mal_osztatho_szamok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adjon meg húszig egy számot:");
            int szam = Convert.ToInt32(Console.ReadLine()) ;
            switch (szam)
            {
                case 3:
                    Console.WriteLine("3-mal osztható számok");
                    break;             
                case 6:                
                    Console.WriteLine("3-mal osztható számok");
                    break;            
                case 9:               
                    Console.WriteLine("3-mal osztható számok");
                    break;            
                case 12:             
                    Console.WriteLine("3-mal osztható számok");
                    break;            
                case 15:              
                    Console.WriteLine("3-mal osztható számok");
                    break;
                case 18:
                    Console.WriteLine("3-mal osztható számok");
                    break;
                default:
                    {
                        Console.WriteLine("Nem osztható 3-mal");
                        break;
                    }
            }
            Console.WriteLine("Ügyes vagy");
            Console.ReadKey();
        }
    }
}
