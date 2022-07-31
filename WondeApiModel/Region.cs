using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WondeApiModel
{
    public class Region
    {
        public string code { get; set; }
        public string domain { get; set; }
        public string school_url { get; set; }
        public Identifiers identifiers { get; set; }
    }
}
