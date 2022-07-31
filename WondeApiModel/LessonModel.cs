using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WondeApiModel
{
    public class LessonModel
    {
        public List<Lesson> data { get; set; }
        public Meta meta { get; set; }
    }

    public class LessonModelSingle
    {
        public Lesson data { get; set; }
        public Meta meta { get; set; }
    }
}
