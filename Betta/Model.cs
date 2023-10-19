using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributesSet
{
    internal class Model : Phone
    {
        static void Models(string[] args)
        {
            Console.WriteLine("Введите число 33");
            int mPhone = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число 77");
            int nPhone = Convert.ToInt32(Console.ReadLine());

            int result = mPhone + nPhone;

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
