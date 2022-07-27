using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WondeApiServices.Services
{
    public class SchoolService
    {
        Wonde.Client client = null;
        public SchoolService(string token)
        {
            client = new Wonde.Client(token);
        }

        //return All Schools
        public async Task<Wonde.ResultIterator> GetAll()
        {
            return client.schools.all();
        }

        public async Task<Wonde.EndPoints.Schools> Get(string id)
        {
            return client.school(id);
        }        

    }
}
