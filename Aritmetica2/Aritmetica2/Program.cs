// See https://aka.ms/new-console-template for more information


using Aritmetica2.CLASS;

Aritmetica c;
Console.WriteLine(" Ingrese el primer numero ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine(" Ingrese el segundo numero ");
int num2 = int.Parse(Console.ReadLine());


c = new Aritmetica(num1, num2);

Console.WriteLine(" La suma de los numeros es:" + c.Getsuma() + " EL producto de los dos ultimos numeros es: " + c.Producto() +
    " La resta de los numeros es igual a:" + c.Rest() + " La division de los numeros es igual a: " + c.Division());
