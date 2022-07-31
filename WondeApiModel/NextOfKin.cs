using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WondeApiModel
{
    public class NextOfKin
    {
        public string id { get; set; }
        public string mis_id { get; set; }
        public string name { get; set; }
        public string telephone_home { get; set; }
        public string telephone_work { get; set; }
        public string telephone_mobile { get; set; }
        public string telephone_primary { get; set; }
        public string email_primary { get; set; }
        public string email_work { get; set; }
        public string email_home { get; set; }
        public CustomDate created_at { get; set; }
        public CustomDate updated_at { get; set; }
    }
}
