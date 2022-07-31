using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WondeApiModel
{
    public class StudentClassModel
    {
        public List<StudentClass> data { get; set; }
        public Meta meta { get; set; }
    }

    public class StudentClassModelSingle
    {
        public StudentClass data { get; set; }
        public Meta meta { get; set; }
    }
}
