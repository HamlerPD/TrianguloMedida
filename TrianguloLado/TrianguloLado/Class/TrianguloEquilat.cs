
using System;
using System.Timers;

namespace TrianguloLado.Class
{
    public class TrianguloEquilat
    {
        
        public void DeterminarMaximo()
        {
            Console.WriteLine(" Escriba el valor de cada del triangulo, /n");
            double lado1 = Convert.ToDouble(Console.ReadLine());
            double lado2 = Convert.ToDouble(Console.ReadLine());
            double lado3 = Convert.ToDouble(Console.ReadLine());
            double resultado = Maximo(lado1, lado2, lado3);

            Console.WriteLine($" El lado mayor es igual a : " + resultado);
            
        }
            

            public double Maximo(double lado1, double lado2, double lado3)
            {
            double valorMaximo = lado1;
            if (lado2 > valorMaximo)
                valorMaximo = lado2;
            if (lado3 > valorMaximo)
                valorMaximo = lado3;
            return valorMaximo;

            }

      
   

    }
}


