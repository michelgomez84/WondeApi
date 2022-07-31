using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WondeApiModel
{
    public class EmployeModel
    {
        public List<Employe> data { get; set; }
        public Meta meta { get; set; }
    }
    public class EmployeModelSingle
    {
        public Employe data { get; set; }
        public Meta meta { get; set; }
    }
}
