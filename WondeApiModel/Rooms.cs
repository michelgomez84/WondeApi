using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WondeApiModel
{
    public class Rooms
    {
        public string id { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public CustomDate created_at { get; set; }
        public CustomDate updated_at { get; set; }
        
    }
}
