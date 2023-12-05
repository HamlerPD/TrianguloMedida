

namespace Aritmetica2.CLASS
{
    public class Aritmetica
    {
        private int num1;
        private int num2;
        

        public Aritmetica(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
           
        }

        public int Getsuma()
        {
            return num1 + num2;
        }

        public int Producto()
        {
            return num1 * num2;
        }

        public int Division()
        {
            return (num1 / num2);
        }

        public int Rest()
        {
            return num1 - num2;
        }
    }
}
