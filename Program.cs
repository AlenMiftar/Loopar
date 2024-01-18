using System;

class Program
{

    static void Main()
    {
        double saldo = 0;
        while (true)
        {
            Console.WriteLine("[I]nsättning");
            Console.WriteLine("[U]ttag");
            Console.WriteLine("[S]aldo");
            Console.WriteLine("[A]vsluta");

            string val = Console.ReadLine().ToLower();

            switch (val)
            {
                case "i":
                    Console.WriteLine("Ange belopp att sätta in: ");
                    double insättning = double.Parse(Console.ReadLine());
                    saldo += insättning;
                    break;

                case "u":
                    Console.WriteLine("Ange belopp att ta ut: ");
                    double uttag = double.Parse(Console.ReadLine());
                    saldo -= uttag;
                    break;
                    
                case "s":
                    Console.WriteLine("Ditt saldo är " + saldo);
                    break;

                case "a":
                    Console.WriteLine("Du loggas nu ut");
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Ogiltigt val. Försök igen.");
                    break;









}   }   }   }           




