using System;
using System.Collections.Generic;

namespace GradeBookConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 5.4; // Var para declarar variable
            var y = 6.6;
            var resultado = x + y; // var siempre ha de tener un valor inicial

            double[] numero = new double[5] {5.1, 3, 3.5, 7.2, 8}; // Inicialización de array 
            double[] Otros_Numeros = {1, 2.1, 3, 5.6, 8}; // Otra manera de inicializar array
            var numero_var = new double[5]; // Otra manera de hacer lo mismo...  
            
            double resul = 0;
            foreach(var num in numero) // Iteraciones con foreach
            {
                resul += num;
            }

            // Listas en C#:
            var ListaDeNotas = new List<double>() {5,5.5,6,10,7,6.3,8,2,0,7}; // Lista de double con inicializador
            double Suma, Media;
            Suma = 0;
            Media = 0;
            foreach (var Nota in ListaDeNotas)
            {
                Suma += Nota;
            }
            Media = Suma/ListaDeNotas.Count;
            Console.ForegroundColor = ConsoleColor.Green; // Cambia color de letra en consola (Solo CMD)
            System.Console.WriteLine($"La suma es {Suma} y la media de notas es {Media}");
            Console.ResetColor(); // Restaura color de letra en consola

            System.Console.WriteLine($"La suma es: {resul} para los números del array");

            System.Console.WriteLine("Sistema inicializado....");
            System.Console.WriteLine($"El resultado es: {resultado}");

            if(args.Length > 0)
            {
                Console.WriteLine($"Se ha introducido {args[0]} en argumentos...");
            }            
            else
                Console.WriteLine("No hay texto a escribir");
        }
    }
}
