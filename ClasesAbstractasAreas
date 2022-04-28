using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemploooo
{
    class Program
    {
        abstract class areas
        {
            private int h;

            public int H { get => h; set => h = value; }

            public abstract void area();


        }

        class triangulo : areas
        {

            private int b, areaT;
            public int B { get => b; set => b = value; }
            public int AreaT { get => areaT; set => areaT = value; }

            public override void area()
            {
                Console.WriteLine("Escriba el valor de la altura del triangulo: ");

                H = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Escriba el valor de la base del triangulo");

                B = Convert.ToInt32(Console.ReadLine());

                AreaT = (B * H) / 2;
                Console.WriteLine("El area del triangulo es: {0}",AreaT);
            }
        }



        static void Main(string[] args)
        {
            try
            {
                triangulo objtriangulo = new triangulo();

                objtriangulo.area();

            }
            catch (Exception) { Console.WriteLine("Usted ha digitado algo mal"); }
            Console.ReadKey();
        }

    }
    
}

