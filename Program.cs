using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace taller2punto2
{
    public class NotasEstudiantes
    {
        #region Atributos y propiedades

        private string nombre, codigo, materia;
        private float nota1, nota2, nota3, promedio;

        #endregion

        #region Propiedades de la clase

        public string Nombre { get => nombre; set => nombre = value; }

        public string Codigo { get => codigo; set => codigo = value; }

        public string Materia { get => materia; set => materia = value; }

        public float Nota1 { get => nota1; set => nota1 = value; }

        public float Nota2 { get => nota2; set => nota2 = value; }

        public float Nota3 { get => nota3; set => nota3 = value; }

        #endregion


        #region Métodos de clase

        public void Mostrar()

        {

            Console.WriteLine("Escriba su nombre completo:");
            nombre = Console.ReadLine();

            Console.WriteLine("Escriba su codigo de estudiante:");
            codigo = Console.ReadLine();

            Console.WriteLine("Escriba el nombre de la materia:");
            materia = Console.ReadLine();

            Console.WriteLine("Escriba su primera nota: ");
            nota1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escriba su segunda nota: ");
            nota2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escriba su tercera nota: ");
            nota3 = Convert.ToInt32(Console.ReadLine());


        }

        #endregion
    }

}