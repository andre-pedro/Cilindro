using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            double a, r, v, s;
            string aux;

            Console.WriteLine("Insere Altura: ");
            aux = Console.ReadLine();
            a = Convert.ToDouble(aux);
            Console.WriteLine("Inserir Raio: ");
            aux = Console.ReadLine();
            r = Convert.ToDouble(aux);
            v = Math.PI * r * r * a;
            s = 2 * Math.PI * r * (r + a);
            Console.WriteLine($"V={v} \n S = {s}");
            




            /* string altura;
            string raio;

            //Pedir Altura
            Console.Write("Indique Altura: ");
            altura = Console.ReadLine();
            int alt = Convert.ToSingle;

            //Pedir Raio
            Console.Write("Indique Raio: ");
            raio = Console.ReadLine();
            int ray = Convert.ToSingle;

            string volume = $"O volume e' {Math.PI * (ray * 2) * alt}";
            string area = $"A A'rea e' {(2 * Math.PI) * (ray + alt)}";
            */

        }
    }
}
