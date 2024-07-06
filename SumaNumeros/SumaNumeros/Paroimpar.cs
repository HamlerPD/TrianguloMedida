using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumaNumeros
{
    public class Paroimpar
    {
        public int num1 = 0;
        public int num2 = 0;
        public int suma = 0;
        public int resta = 0;

        public void Sumando()
        {
            Console.WriteLine("Ingrese un numero");
            num1 =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ingrese otro numero");
            num2=Convert.ToInt32(Console.ReadLine());

            suma = num1 + num2;
            Console.WriteLine($"La suma es igual a: " + suma);

            if(( suma % 2)== 0){
                Console.WriteLine(" El numero es par");
            }
            else
            {
                Console.WriteLine("El numero es impar");
            }
        }

        public void Restando()
        {
            resta = num1 - num2;
            Console.WriteLine($"la esta de los numeros es igual a; " + resta);
        }

        
    }
}
