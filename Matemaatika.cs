using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulaator
{
    internal class Matemaatika
    {
        public float number1;
        public float number2;
        public string tehing = "";
        public float result;

        public float arvutus()
        {
            if (tehing == "+")
            {
                result = number1 + number2;
            }
            if (tehing == "-")
            {
                result = number1 - number2;
            }
            if (tehing == "*")
            {
                result = number1 * number2;
            }
            if (tehing == "/")
            {
                result = number1 / number2;
            }
            return result;
        }
    }
}
