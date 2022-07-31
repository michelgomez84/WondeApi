using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WondeApiModel
{
    public class Meta
    {
        public Pagination pagination { get; set; }
        public List<string> includes { get; set; }
    }
}
