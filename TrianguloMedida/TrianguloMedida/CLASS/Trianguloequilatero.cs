

namespace TrianguloMedida.CLASS
{
    public class Trianguloequilatero
    {
        #region " Atributos de nuestra clase"
        public int num1 = 0;
        public int num2 = 0;
        public int num3 = 0;
        string linea = string.Empty;
        #endregion


        #region " Metodos de la clase"
        public void Obtenerdatos()
        {

            Console.WriteLine(" Ingrese  el primer valor del lado del triangulo");
            linea = Console.ReadLine();
            num1 = Convert.ToInt32(linea);
            Console.WriteLine(" Ingrese  el primer valor del lado del triangulo");
            linea = Console.ReadLine();
            num2 = Convert.ToInt32(linea);
            Console.WriteLine(" Ingrese  el primer valor del lado del triangulo");
            linea = Console.ReadLine();
            num3 = Convert.ToInt32(linea);
            Console.WriteLine("-------------------------------------------------------------------------------------");

            if (num1 == num2 && (num2 == num3))
            {
                Console.WriteLine($" El triangulo  es equilatero");
            }
            else
            {
                Console.WriteLine($" El triangulo no es equilatero");
                if (num1 == num2 && (num2 < num3))
                {
                    Console.WriteLine($" El lado mayor es" + num3);
                }
                else
                {
                    if (num1 < num2 && (num2 < num3))
                    {
                        Console.WriteLine($" El lado mayor es" + num3);
                    }
                    else
                    {
                        if (num1 > num2 && (num1 < num3))
                        {
                            Console.WriteLine($" El lado mayor es" + num3);
                        }
                        else
                        {
                            if (num2 > num3 && (num2 < num1))
                            {
                                Console.WriteLine($" El lado mayor es" + num1);
                            }
                            else
                            {
                                if (num2 < num3 && (num3 < num1))
                                {
                                    Console.WriteLine($" El lado mayor es" + num1);
                                }
                                else
                                {
                                    if (num1 < num3 && (num3 < num2))
                                    {
                                        Console.WriteLine($" El lado mayor es" + num2);
                                    }
                                    else
                                    {
                                        if (num1 > num3 && (num3 < num2))
                                        {
                                            Console.WriteLine($" El lado mayor es" + num2);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                Console.ReadLine();
            }
        }
        #endregion
    }
}
