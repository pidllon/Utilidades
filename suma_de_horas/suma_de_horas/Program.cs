using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suma_de_horas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int partMin, partHora, sumaHoras, partMin1, partHora1, sumaMin;
            Console.WriteLine("HORA DE ENTRADA");
            Console.WriteLine("Introduce (en formato 24h) la parte de horas, por ejemplos 12:30 seria 12:");
            partHora = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Introduce ahora los minutos de igual manera que las horas:");
            partMin = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("HORA DE SALIDA");
            Console.WriteLine("Introduce la parte de horas:");
            partHora1 = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Introduce la parte de minutos:");
            partMin1 = int.Parse(Console.ReadLine());
            Console.Clear();
            sumaHoras = partHora1 - partHora;
            sumaMin = partMin1 + (60 - partMin);
            if(sumaMin > 60)
            {
                float minR, minH, minH1;
                minR = sumaMin % 60;
                minH = sumaMin - minR;
                minH1 = minH / 60;
                int totalHoras = (int)(sumaHoras + minH1);
                Console.WriteLine($"Horas Totales {totalHoras} horas y {minR} minutos.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"Horas Totales {sumaHoras} horas y {sumaMin} minutos.");
                Console.ReadLine();
            }
        }
    }
}
