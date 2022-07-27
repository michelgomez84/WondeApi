using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WondeApiServicess.Services
{
    public class AttendanceService
    {
        Wonde.Client client = null;
        public AttendanceService(string token)
        {
            client = new Wonde.Client(token);
        }

        //return All Schools
        public async Task<Wonde.ResultIterator> GetAll(string schoolId = null)
        {
            return string.IsNullOrEmpty(schoolId) ? client.schools.attendance.all() : client.school(schoolId).attendance.all();
        }

        public async Task<object> Get(string id)
        {
            return client.schools.attendance.get(id);
        }
    }
}
