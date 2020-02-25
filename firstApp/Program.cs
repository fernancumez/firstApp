using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Ejemplos prácticos

namespace firstApp {
    class Program {
        static void Main(string[] args) {
            //Variables
            int empleados;

            var nombres = new List<string> { "fernando", "antonio", "lara" };
            nombres.Add("Martin");
            nombres.Sort();

            foreach(var nombre in nombres) {
                Console.WriteLine(nombre);                
            }

            var index = nombres.IndexOf("antonio");
            Console.WriteLine($"Econtrando { nombres[index] } en la posicion {index}");

            empleados = Convert.ToInt32(Console.ReadLine());


            Console.ReadKey();
        }
    }
}
