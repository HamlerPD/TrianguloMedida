// Fig. 3.26: Comparacion.cs
 // Comparación de enteros mediante el uso de instrucciones if, operadores de
// igualdad y operadores relacionales.using System;
5
6 public class Comparacion
7 {
    8 // El método Main comienza la ejecución de la aplicación de C#
9 public static void Main(string[] args)
10 {
        11 int numero1; // declara el primer número a comparar
        12 int numero2; // declara el segundo número a comparar
        13
14 //pide al usuario y lee el primer número
15 Console.Write("Escriba el primer entero: ");
        16 numero1 = Convert.ToInt32(Console.ReadLine());
        17
18 //pide al usuario y lee el segundo número
19 Console.Write("Escriba el segundo entero: ");
        20 numero2 = Convert.ToInt32(Console.ReadLine());
        21
22 if (numero1 == numero2)
            23 Console.WriteLine("{0} == {1}", numero1, numero2);
        24
25 if (numero1 != numero2)
            26 Console.WriteLine("{0} != {1}", numero1, numero2);
        27
28 if (numero1 < numero2)
            29 Console.WriteLine("{0} < {1}", numero1, numero2);
        30
31 if (numero1 > numero2)
            32 Console.WriteLine("{0} > {1}", numero1, numero2);
        33
34 if (numero1 <= numero2)
            35 Console.WriteLine("{0} <= {1}", numero1, numero2);
        36
37 if (numero1 >= numero2)
            38 Console.WriteLine("{0} >= {1}", numero1, numero2);
        39 } // fin del método Main
    40 } // fin de la clase Comparacion
