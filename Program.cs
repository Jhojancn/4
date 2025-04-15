using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Ej4();
            Ej5();
            Ej6();


        }
        static void Ej1()
        {
            Console.WriteLine("\nEjercicio 1");
            Random num = new Random();
            int a = num.Next(31);
            int b = num.Next(31);
            Console.WriteLine($"a={a} \nb={b}");
            if (a < b)
            {
                Console.WriteLine("Intercambio");
                int aux = a; a = b; b = aux;
                Console.WriteLine($"a={a} \nb={b}");
            }
            else
            {
                a++; b++;
                Console.WriteLine("Incremento");
                Console.WriteLine($"a={a} \nb={b}");
            }
        }
        static void Ej2()
        {
            Console.WriteLine("\nEjercicio 2");
            Console.Write("Elija una opción \n (1)s \n (2)c \n (3)v \n (4)d:");
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1: Console.WriteLine("Soltero"); break;
                case 2: Console.WriteLine("Casado"); break;
                case 3: Console.WriteLine("Viudo"); break;
                case 4: Console.WriteLine("Divorciado"); break;
                default: Console.WriteLine("Opción sin especificar"); break;
            }
        }
        static void Ej3()
        {
            /*Encuentre el mayor valor de tres números dados*/
            Console.WriteLine("\nEjercicio3");
            Random num = new Random();
            int n1 = num.Next(21);
            int n2 = num.Next(21);
            int n3 = num.Next(21);
            Console.WriteLine($"n1={n1} \nn2={n2}\nn3={n3}");
            int max = n1;
            if (n2 > max) max = n2;
            if (n3 > max) max = n3;
            Console.WriteLine($"Mayor={max}");

        }
        static void Ej4()
        {/*Ordene de mayor a menor tres números ingresados por teclado.*/
            Console.WriteLine("\nEjercicio4");
            Console.Write("Primer número="); int n1 = int.Parse(Console.ReadLine());
            Console.Write("Segundo número="); int n2 = int.Parse(Console.ReadLine());
            Console.Write("Tercer número="); int n3 = int.Parse(Console.ReadLine());
            int max = n1;
            int min = n3;
            if (n2 > max) max = n2;
            if (n3 > max) max = n3;     
            if (n2 < min) min = n2;
            if (n1 < min) min = n1;
            int suma= n1 + n2 + n3;
            int suma_2 = max + min;
            int medio = suma-suma_2;
            Console.WriteLine($"Mayor={max}, {medio}, {min}");


        }

        static void Ej5()
        {
            /*Elabore un algoritmo que resuelva las raíces reales cuadráticas*/
            Random num = new Random();
            int a = num.Next(21);
            int b = num.Next(21);
            int c = num.Next(21);
            Console.WriteLine($"La ecuación es la siguiente{a}x2 + {b}x + {c}");
            double d = Math.Pow(b, 2) - 4 * a * c;
            double r1 = (b - Math.Sqrt(d)) / 2 * a;
            double r2 = (b + Math.Sqrt(d)) / 2 * a;
            if (d > 0) Console.WriteLine($"Raíz 1= {r1}, Raíz 2={r2}");
            else Console.WriteLine("No existe esa raíz");

        }

        static void Ej6()
        {
            /*Dado un número que varíe en el rango de 1 a 12, mostrar el nombre del
mes al que representa e indicar el número de días de éste.*/
            Random num = new Random();
            int a = num.Next(13);
            Console.WriteLine(a);
            switch (a)
            {
                case 1: Console.WriteLine("Enero:30"); break;
                case 2: Console.WriteLine("Febrero:28"); break;
                case 3: Console.WriteLine("Marzo:31"); break;
                case 4: Console.WriteLine("Abril:30"); break;
                case 5: Console.WriteLine("Mayo:31"); break;
                case 6: Console.WriteLine("Junio:30"); break;
                case 7: Console.WriteLine("Julio:31"); break;
                case 8: Console.WriteLine("Agosto:31"); break;
                case 9: Console.WriteLine("Septiembre:30"); break;
                case 10: Console.WriteLine("Octubre:31"); break;
                case 11: Console.WriteLine("Noviembre:30"); break;
                case 12: Console.WriteLine("Diciembre:31"); break;
            }

        }




    }
}
