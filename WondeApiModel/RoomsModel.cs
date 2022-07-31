using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WondeApiModel
{
    public class RoomsModel
    {
        public List<Rooms> data { get; set; }
        public Meta meta { get; set; }
    }
    public class RoomsModelSingle
    {
        public Rooms data { get; set; }
        public Meta meta { get; set; }
    }
}
