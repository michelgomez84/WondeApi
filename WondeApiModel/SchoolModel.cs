using System.ComponentModel;

namespace WondeApiModel
{
    public enum schoolStatus
    {
        [Description("")]
        Approved=0,
        [Description("all")]
        All = 1,
        [Description("pending")]
        Pending = 2,
        [Description("audited")]
        Audited = 3, 
        [Description("offline")]
        Offline = 4,
        [Description("revoked")]
        Revoked = 5,
        [Description("declined")]
        Declined = 6
    }
    public class SchoolModel
    {
        public List<School> data { get; set; }
        public Meta meta { get; set; }
    }
    public class SchoolModelSingle
    {
        public School data { get; set; }
    }
}