using System;
namespace TP1{
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
        public static double Operation(double num1, double num2, string op);
    }
    class Calculatrice
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Faites votre choix parmi la liste suivante :");
            Console.WriteLine("(+) - Addition");
            Console.WriteLine("(-) - Soustraction");
            Console.WriteLine("(*) - Multiplication");
            Console.WriteLine("(/) - Division");
            Console.WriteLine("Votre choix?");
            string op = Console.ReadLine();
            double result = double.NaN;
            double num1, num2;

            switch (op)
            {
                case "+":
                    Double.TryParse(Console.ReadLine(), out num1);
                    Double.TryParse(Console.ReadLine(), out num2);
                    double somme = num1 + num2;
                    Console.WriteLine($"La somme est : {somme}");
                    break;

                case "-":
                    Double.TryParse(Console.ReadLine(), out num1);
                    Double.TryParse(Console.ReadLine(), out num2);
                    double soustraction = num1 - num2;
                    Console.WriteLine($"La soustraction est : {soustraction}");
                    break;

                case "*":
                    Double.TryParse(Console.ReadLine(), out num1);
                    Double.TryParse(Console.ReadLine(), out num2);
                    double multiplication = num1 * num2;
                    Console.WriteLine($"La multiplication est : {multiplication}");
                    break;

                case "/":
                    Double.TryParse(Console.ReadLine(), out num1);
                    Double.TryParse(Console.ReadLine(), out num2);
                    double division = num1 / num2;
                    Console.WriteLine($"La division est : {division}");
                    break;

                default:
                    Console.WriteLine("Choix invalide !");
                    break;
            }

            // Attendre que l'utilisateur appuie sur une touche avant de fermer la console
            Console.ReadKey();
        }
    }
}
