using System;
namespace Deuxieme{
    class Program{
        public static void Main(){
            double num1, num2, somme, soustraction, multi;
            //num1 = Convert.ToDouble (Console.ReadLine());
            //num2 = Convert.ToDouble (Console.ReadLine());
            Double.TryParse(Console.ReadLine(), out num1);
            Double.TryParse(Console.ReadLine(), out num2);
            somme = num1+num2;
            soustraction = num1-num2;
            multi = num1*num2;
            Console.WriteLine($"La somme est : {somme}");
            Console.WriteLine($"La soustraction est : {soustraction}");
            Console.WriteLine($"La multiplication est : {multi}");
        }
    }
}