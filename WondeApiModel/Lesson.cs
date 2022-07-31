using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WondeApiModel
{
    public class Lesson
    {
        public string id { get; set; }
        public string mis_id { get; set; }

        public string room { get; set; }
        public string period { get; set; }
        public int? period_instance_id { get; set; }
        public string employee_id { get; set; }
        //public Employe employee { get; set; }
        public bool? alternative { get; set; }
        public int? day_number { get; set; }
        public CustomDate start_at { get; set; }
        public CustomDate end_at { get; set; }
        public CustomDate created_at { get; set; }
        public CustomDate updated_at { get; set; }
        
        

    }
}
