using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WondeApiModel
{
    public class EmploymentDetails
    {
        public bool teaching_staff { get; set; }
        public bool current { get; set; }
        public string teacher_number { get; set; }
        public string staff_code { get; set; }
        public CustomDate employment_start_date { get; set; }
        public object employment_end_date { get; set; }
        public CustomDate local_authority_start_date { get; set; }
        public string employee_payroll_number { get; set; }
        public string role_text { get; set; }
        public string qualified_teacher_status { get; set; }
        public string qualified_teacher_status_route { get; set; }
        public string higher_level_teaching_assistant_status { get; set; }
    }
}
