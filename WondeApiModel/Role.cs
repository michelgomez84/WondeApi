using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WondeApiModel
{
    public class Role
    {
        public string id { get; set; }
        public string mis_id { get; set; }
        public string role { get; set; }
        public string role_code { get; set; }
        public string contract { get; set; }
        public CustomDate start_date { get; set; }
        public CustomDate end_date { get; set; }
        public CustomDate created_at { get; set; }
        public CustomDate updated_at { get; set; }
    }
}
