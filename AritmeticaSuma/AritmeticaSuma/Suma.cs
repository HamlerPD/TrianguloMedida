using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AritmeticaSuma
{
    //Suma de 3 numeros
    public class Suma
    {
        public static void Main() 
        {
            int num1 = 0;
            int num2 = 0;
            int suma = 0;

            Console.Write(" Escriba el primero numero");
            num1 = Convert.ToInt32(Console.ReadLine() );

            Console.Write("Escriba el segundo numero");
            num2 = Convert.ToInt32(Console.ReadLine());

            suma = num1 + num2;

            Console.WriteLine(" LA suma es igua a" + suma);

        }

    }
}
