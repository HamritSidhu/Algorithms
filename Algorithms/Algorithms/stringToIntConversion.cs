using System;
using System.Text;

/**
 * Problem Definition: Convert a string to integer 
 */

namespace Algorithms
{
    class stringToIntConversion
    {
        public int getInt(string value) {
             ASCIIEncoding encode = new ASCIIEncoding();
             byte byteZero = encode.GetBytes("0")[0];
             byte[] charAsciis = encode.GetBytes(value);
             int result = 0;
             int power = 0;
             int add = 0;
             for (int i = charAsciis.Length - 1; i >= 0; i--)
             {
                 add = (charAsciis[i] - byteZero) * (int)Math.Pow(10, power);
                 result += add;
                 power++;
             }

             return result;
        }

        public bool isInt(string value) {
            ASCIIEncoding encode = new ASCIIEncoding();

            byte lowestInt = encode.GetBytes("0")[0];
            byte highestInt = encode.GetBytes("9")[0];

            byte[] charAsciis = encode.GetBytes(value);
            foreach (byte b in charAsciis)
            {
                if (b > highestInt || b < lowestInt)
                    return false;
            }

            return true;
        }

        public void convert(string value) {
            if (value != null && value.Length > 0)
            {
                bool convertable = this.isInt(value);
                Console.WriteLine("Input String: " + value);
                if (convertable)
                {
                    int converted = this.getInt(value);
                    Console.WriteLine("Output integer: " + converted);
                }
                else
                    Console.WriteLine("The string cannot be converted to an integer");

            }
            else 
                Console.WriteLine("Invalid string");
            
        }

    }
}
