using System;

namespace GradeBookConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length > 0)
            {
                //string Decir = "Se ha introducido: " + args[0];
                Console.WriteLine($"Se ha introducido {args[0]} en argumentos...");
            }            
            else
                Console.WriteLine("No hay texto a escribir");
        }
    }
}
