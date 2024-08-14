using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Matrices
{
    public class Cibersecurity
    {
        public Cibersecurity()
        {

            string[] FraudulentOrdersId = new string[8];

            FraudulentOrdersId[0] = "B123";
            FraudulentOrdersId[1] = "C234";
            FraudulentOrdersId[2] = "B345";
            FraudulentOrdersId[3] = "C150";
            FraudulentOrdersId[4] = "B177";
            FraudulentOrdersId[5] = "G303";
            FraudulentOrdersId[6] = "C235";
            FraudulentOrdersId[7] = "B179";

          foreach (String items in FraudulentOrdersId)
            {
                
                if (items.StartsWith("B"))
                {
                    Console.WriteLine($"This {items} orders is fraudulent: ");
                }
            }



        }
    } 
} 
