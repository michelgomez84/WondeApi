using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WondeApiModel
{
    public class Allowance
    {
        public string id { get; set; }
        public string mis_id { get; set; }
        public CustomDate start_date { get; set; }
        public CustomDate end_date { get; set; }
        public int amount { get; set; }
        public string type { get; set; }
        public string allowance { get; set; }
        public string code { get; set; }
        public string payroll_allowance { get; set; }
        public string allowance_reason { get; set; }
        public CustomDate created_at { get; set; }
        public CustomDate updated_at { get; set; }
    }
}
