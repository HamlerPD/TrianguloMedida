namespace Ejercicio_if_elase.Sueldo
{
    internal class Sueldo
    {
        private double nota1;
        private double nota2;
        private double nota3;

        public Sueldo(double nota1, double nota2, double nota3)
        {
            this.nota1 = nota1;
            this.nota2 = nota2;
            this.nota3 = nota3;
        }
        public double Getsuma()
        {
            return nota1 + nota2 + nota3;
        }
        public double Promedio()
        {
            return Getsuma / 3;
        }

    }
}   
