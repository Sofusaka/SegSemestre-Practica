using System;
using System.Text;


namespace Ejercicio07
{
    class meses
    {
        #region atributos y propiedades


        private string m, a, d;

        public string M { get => m; set => m = value; }
        public string A { get => a; set => a = value; }
        public string D { get => d; set => d = value; }

        #endregion

        #region Constructores



        Dictionary<string, string> mes = new Dictionary<string, string>()
            {

                 { "enero","01"},
                 { "febrero","02"},
                 { "marzo","03"},
                 { "abril","04"},
                 { "mayo","05"},
                 { "junio","06"},
                 { "julio","07"},
                 { "agosto","08"},
                 { "septiembre","09"},
                 { "octubre","10"},
                 { "noviembre","11"},
                 { "diciembre","12"},


            };


        #endregion

        #region Métodos de la clase

       
        public void ConvertirFecha()
        {
            M = "a";
            Console.WriteLine("*********Conversión de fechas*********");
            Console.WriteLine("");
            Console.WriteLine("Ingrese un día:");
            D = Console.ReadLine();

            Console.WriteLine("Ingrese un mes:");
            M = Console.ReadLine();

            Console.WriteLine("Ingrese un año:");
            A = Console.ReadLine();


            string mesfinal;

            bool valido = mes.TryGetValue( M, out mesfinal);
            if (valido)
            {
              
                Console.WriteLine("La fecha que usted ha ingresado es {0}/{1}/{2}", D, mesfinal, A);
            }
            else
            {
                Console.WriteLine("El mes ({0}) ingresado es inválido", M);
            }

           
        }
        #endregion

        #region ejecucion consola
        static void Main(string[] args)
            {
                ///////////////////
                Console.ForegroundColor = ConsoleColor.Magenta;
                
                meses objmeses = new meses();

                objmeses.ConvertirFecha();
                Console.ReadKey();
            }
        


    }
}
#endregion
