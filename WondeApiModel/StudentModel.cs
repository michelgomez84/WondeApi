using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WondeApiModel
{
    public class StudentModel
    {
        public List<Student> data { get; set; }
        public Meta meta { get; set; }
    }
    public class StudentModelSingle
    {
        public Student data { get; set; }
        public Meta meta { get; set; }
    }
}
