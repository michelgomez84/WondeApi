using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WondeApiServices.Services
{
    public class PeriodService
    {
        Wonde.Client client = null;
        public PeriodService(string token)
        {
            client = new Wonde.Client(token);
        }

        //return All Schools
        public async Task<Wonde.ResultIterator> GetAll(string schoolId = null)
        {
            return string.IsNullOrEmpty(schoolId) ? client.schools.periods.all() : client.school(schoolId).periods.all();
        }

        public async Task<object> Get(string id)
        {
            return client.schools.periods.get(id);
        }
    }
}
