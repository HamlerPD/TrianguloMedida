using Ejercicio_if_elase.Sueldo;


internal class Program
{
    private static void Main(string[] args)
    {
        Sueldo c;
        Console.WriteLine(" Ingrese la primera nota");
        double nota1 = double.Parse(Console.ReadLine());
        Console.WriteLine(" Ingrese la segunda nota");
        double nota2 = double.Parse(Console.ReadLine());
        Console.WriteLine(" ingrese la tercera nota ");
        double nota3 = double.Parse(Console.ReadLine());

        c = new Sueldo(nota1, nota2, nota3);


        Console.WriteLine("La suma de las 3 notas es" + c.Getsuma());
        Console.WriteLine(" El promedio del estudiante es " + c.Promedio());
    }
}