using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WondeApiModel
{
    public class Pagination
    {
        public string next { get; set; }
        public string previous { get; set; }
        public bool more { get; set; }
        public int per_page { get; set; }
        public int current_page { get; set; }
    }
}
