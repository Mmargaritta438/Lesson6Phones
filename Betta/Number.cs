using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributesSet
{
    class Number : Phone
    {
        static void Numbers(string[] args)
        {
            string str = "1.9";

            NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ".",
            };

            double xPhone = Convert.ToDouble(str, numberFormatInfo);
        }
    }
}
