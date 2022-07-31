using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WondeApiModel
{
    public class Scale
    {
        public string id { get; set; }
        public string mis_id { get; set; }
        public CustomDate start_date { get; set; }
        public CustomDate end_date { get; set; }
        public int scale_point { get; set; }
        public string pay_scale { get; set; }
        public string pay_scale_code { get; set; }
        public int minimum_amount { get; set; }
        public int maximum_amount { get; set; }
        public string notes { get; set; }
        public CustomDate created_at { get; set; }
        public CustomDate updated_at { get; set; }
    }
}
