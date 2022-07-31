using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WondeApiModel
{
    public class Salary
    {
        public string id { get; set; }
        public string payroll_number { get; set; }
        public string salary { get; set; }
        public string fte_salary { get; set; }
        public string total_pay { get; set; }
        public CustomDate latest_pay_review_date { get; set; }
        public string superannuation { get; set; }
        public string pay_factor { get; set; }
        public string service_term { get; set; }
        public string hours_week { get; set; }
        public string weeks_year { get; set; }
        public string hours_year { get; set; }
        public string fte_hours { get; set; }
        public CustomDate created_at { get; set; }
        public CustomDate updated_at { get; set; }
    }
}
