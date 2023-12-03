// See https://aka.ms/new-console-template for more informati


void calcularnotas()
{
    int cantidadAprobos = 0;
    int cantidadReprobados = 0;
    int cantidaddeNotas = 0;
    int nota = 0;
    string linea = string.Empty;

    Console.WriteLine( " Ingrese cantidad de notas");
    cantidaddeNotas = int.Parse(Console.ReadLine());

    for int i= 0; int < cantidaddeNotas; i++)
    {
        Console.WriteLine($" Ingrese nota: {i} ");
        linea = Console.ReadLine();
        if(int.TryParse(linea, out int, myValue )
        if (nota>=10)
        {
            cantidadAprobos += 1;
        }
    }
}
