using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WondeApiServices.Services
{
    public class LessonService
    {
        Wonde.Client client = null;
        public LessonService(string token)
        {
            client = new Wonde.Client(token);
        }

        //return All Schools
        public async Task<Wonde.ResultIterator> GetAll(string schoolId = null)
        {
            return string.IsNullOrEmpty(schoolId) ? client.schools.lessons.all() : client.school(schoolId).lessons.all();
        }

        public async Task<object> Get(string id)
        {
            return client.schools.lessons.get(id);
        }
    }
}
