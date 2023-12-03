int mes = 0;
int dia = 0;
int año = 0;
string linea = string.Empty;



Console.WriteLine(" ingrese el dia ");
linea = Console.ReadLine();
dia = Convert.ToInt32(linea);

Console.WriteLine(" ingrese el mes ");
linea = Console.ReadLine();
mes = Convert.ToInt32(linea);

Console.WriteLine("ingrese el año");
linea = Console.ReadLine();
año = Convert.ToInt32(linea);
     
if ( mes == 1 || mes == 2 || mes ==3 )
{
    Console.WriteLine(" El Mes corresponde al primer trimestre ");
}
else
{
    Console.WriteLine(" El mes no corresponde al primer trimestre ");
}
