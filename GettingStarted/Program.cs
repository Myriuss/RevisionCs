using System;
namespace premier {
       class Program
         {
            public static void Main()
            {
                Console.WriteLine("Bonjour !\n");
                Console.Write("Entrer votre nom : ");
                string nom = Console.ReadLine();
                Console.WriteLine($" Bienvenu {nom}");
                var val = Console.ReadLine();
                int n;
                int.TryParse(val, out n);
                Console.WriteLine("Vous avez saisi {0}", n);
            } 
} }