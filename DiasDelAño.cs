using System;

using System;
using System.Text;


namespace Ejercicio12
{
    class diasdelaño
    {
        #region atributos y propiedades

        int dia, mes, dia_año;

        public int Dia { get => dia; set => dia = value; }
        public int Mes { get => mes; set => mes = value; }
        public int Dia_año { get => dia_año; set => dia_año = value; }

        #endregion

        #region Metodos de la clase

        public void CalcularDia()
        {
            Console.WriteLine("***********Calcular días del año***********");
            Console.WriteLine("");
            Console.WriteLine("Ingrese el día del mes a calcular");
            Dia = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el mes que corresponde al día");
            Mes = int.Parse(Console.ReadLine());

            if (Dia <= 31 && Dia >= 1 && Mes <= 12 && Mes >= 1)
            {
                Dia_año = Dia;
                switch (mes)
                {

                    case 1:
                        Dia_año = Dia_año;
                        Console.WriteLine("El día {0} del mes {1} es el día {2} del año.", Dia, Mes, Dia_año);
                        break;
                    case 2:
                        Dia_año = Dia_año + 31;
                        Console.WriteLine("El día {0} del mes {1} es el día {2} del año.", Dia, Mes, Dia_año);
                        break;
                    case 3:
                        Dia_año = Dia_año + 59;
                        Console.WriteLine("El día {0} del mes {1} es el día {2} del año.", Dia, Mes, Dia_año);
                        break;
                    case 4:
                        Dia_año = Dia_año + 90;
                        Console.WriteLine("El día {0} del mes {1} es el día {2} del año.", Dia, Mes, Dia_año);
                        break;
                    case 5:
                        Dia_año = Dia_año + 120;
                        Console.WriteLine("El día {0} del mes {1} es el día {2} del año.", Dia, Mes, Dia_año);
                        break;
                    case 6:
                        Dia_año = Dia_año + 151;
                        Console.WriteLine("El día {0} del mes {1} es el día {2} del año.", Dia, Mes, Dia_año);
                        break;
                    case 7:
                        Dia_año = Dia_año + 181;
                        Console.WriteLine("El día {0} del mes {1} es el día {2} del año.", Dia, Mes, Dia_año);
                        break;
                    case 8:
                        Dia_año = Dia_año + 212;
                        Console.WriteLine("El día {0} del mes {1} es el día {2} del año.", Dia, Mes, Dia_año);
                        break;
                    case 9:
                        Dia_año = Dia_año + 243;
                        Console.WriteLine("El día {0} del mes {1} es el día {2} del año.", Dia, Mes, Dia_año);
                        break;
                    case 10:
                        Dia_año = Dia_año + 273;
                        Console.WriteLine("El día {0} del mes {1} es el día {2} del año.", Dia, Mes, Dia_año);
                        break;
                    case 11:
                        Dia_año = Dia_año + 304;
                        Console.WriteLine("El día {0} del mes {1} es el día {2} del año.", Dia, Mes, Dia_año);
                        break;
                    case 12:
                        Dia_año = Dia_año + 334;
                        Console.WriteLine("El día {0} del mes {1} es el día {2} del año.", Dia, Mes, Dia_año);
                        break;
                }
            }
            else { Console.WriteLine("Usted ha ingresado datos que no corresponden."); }
            
           

            }
        #endregion

        #region ejecucion consola
        static void Main(string[] args)
        {
            ///////////////////
            Console.ForegroundColor = ConsoleColor.Magenta;
            diasdelaño objdias = new diasdelaño();
            objdias.CalcularDia();
            Console.ReadKey();
        }
    }
}
#endregion
