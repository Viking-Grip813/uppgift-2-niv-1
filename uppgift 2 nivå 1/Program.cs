using System;
namespace uppgift2
{ class Program
    { static void Main(string[] args)
        {
            
            int tal = 1;
            while (tal > 0)
            {
                Console.WriteLine("Skriv ett tal");
                int tal1 = int.Parse(Console.ReadLine());
                if (tal1 == 0) 
                break;

                
            }
        }
    }
}