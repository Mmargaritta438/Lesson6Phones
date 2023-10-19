using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributesSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var o = new Phone { Id = 1, Date = DateTime.Now };
            if (Helpers.HasCustomAttribute(o))
            {
                Console.WriteLine("Has custom");
            }
            else
            {
                Console.WriteLine("Has NOT custom");
            }

            var json = Newtonsoft.Json.JsonConvert.SerializeObject(o);
            Console.WriteLine(json);

            Console.ReadKey();
        }
    }
}
