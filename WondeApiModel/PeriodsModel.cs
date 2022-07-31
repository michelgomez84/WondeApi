using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WondeApiModel
{
    public class PeriodsModel
    {
        public List<Periods> data { get; set; }
        public Meta meta { get; set; }
    }
    public class PeriodsModelSingle
    {
        public Periods data { get; set; }
        public Meta meta { get; set; }
    }
}
