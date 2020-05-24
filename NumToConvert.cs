using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decimal_Converter
{
    class NumToConvert
    {
        public long Number
        { get; set; }

        public NumToConvert(long num)
        {
            this.Number = num;
        }

        public string ConvertToBaseX(long x, char[] values)
        {
            long tempNum = this.Number; 
            int location = 0;
            string result = "";
            for (int i = 64; i >= 0; i--)
            {
                location = (int)(tempNum / Math.Pow(x, i));
                result += values[location];
                tempNum -= (long)Math.Pow(x, i) * location;
            }
            result = result.TrimStart('0');
            return result;
        }
    }
}
