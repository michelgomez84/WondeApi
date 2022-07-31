using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WondeApiModel
{
    public class StudentClass
    {
        public string id { get; set; }
        public string mis_id { get; set; }
        public string name { get; set; }
        public string code { get; set; }
        public string description { get; set; }
        public string subject { get; set; }
        public CustomDate restored_at { get; set; }
        public CustomDate created_at { get; set; }
        public CustomDate updated_at { get; set; }
        public bool? alternative { get; set; }

    }
}
