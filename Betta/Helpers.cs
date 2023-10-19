using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AttributesSet
{
    internal class Helpers
    {
        public static bool HasCustomAttribute(IPhone o)
        {
            var attrs = o.GetType().GetCustomAttributes(false);
            return attrs.Any(a => a.GetType() == typeof(PhoneClassAttribute));
        }
    }
}
