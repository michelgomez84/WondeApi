using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WondeApiServices.Services
{
    public class EmployesService
    {
        Wonde.Client client = null;
        public EmployesService(string token)
        {
            client = new Wonde.Client(token);
        }

        //return All Schools
        public async Task<Wonde.ResultIterator> GetAll(string schoolId=null)
        {
            return string.IsNullOrEmpty(schoolId)? client.schools.employees.all(): client.school(schoolId).employees.all();
        }

        public async Task<object> Get(string id)
        {
            return client.schools.employees.get(id);
        }        

    }
}
