using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributesSet
{
    [PhoneClass]
    class Phone : IPhone
    {
        public int Id { get; set; }
        public string Number { get; set; }    

        [Newtonsoft.Json.JsonConverter(typeof(DateCustomConverter))]    
        public DateTime Date { get; set; }
    }
}
