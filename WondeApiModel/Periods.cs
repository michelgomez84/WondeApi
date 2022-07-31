using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WondeApiModel
{
    public class Periods
    {
        public string id { get; set; }
        public string start_time { get; set; }
        public string end_time { get; set; }
        public string name { get; set; }
        public string day { get; set; }
        public int? day_number { get; set; }
        public string description { get; set; }
        public CustomDate created_at { get; set; }
        public CustomDate updated_at { get; set; }        

    }
}
