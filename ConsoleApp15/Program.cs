using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tope = 0;
            float promedio = 0;
            float promedio2 = 0;
            int dividir = 0;

            while (tope !=-1){
                Console.Write("Ingrese una nota: ");
                string stop = Console.ReadLine();
                if (stop != "STOP")
                {
                    int num = int.Parse(stop);
                    promedio = promedio + num;
                    dividir++;
                }
                else if (stop == "STOP")
                {
                    promedio2 = promedio / dividir;
                    Console.WriteLine("============================");
                    Console.WriteLine("El promedio es: " + promedio2);
                    tope = -1;
                }
            }
            Console.ReadLine();
        }
    }
}
