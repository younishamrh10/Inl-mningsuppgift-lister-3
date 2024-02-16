using System;
using System.Collections.Generic;

namespace Inlämningsuppgift_lister_3
{

    class program 
    {
        static void Main(string[] args)
        {
            Dictionary<string,int> länder = new Dictionary<string, int>();

            länder["Sverige"] = 450;
            länder["Norge"] = 385;
            länder["Danmark"] = 43;
            länder["Finland"] = 338;
            {
                Console.WriteLine("Välj land mellan Sverige, Norge, Danmark, Finland för att få arean på landet du väljer");
                string val = Console.ReadLine().ToLower();
            switch (val)
            {
                case "sverige":
                    Console.WriteLine("450 km^2");
                    break;
                case "norge":
                    Console.WriteLine("385 km^2");
                    break;
                case "danmark":
                    Console.WriteLine("43 km^2");
                    break;
                case "finland":
                    Console.WriteLine("338 km^2");
                    break;
                default:
                    Console.WriteLine("Du skriv fel");
                    break;


            }
            }
        }
    }
}