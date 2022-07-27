using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WondeApiServices.IServices;

namespace WondeApiServices.Services
{
    public class RoomService: IRoomService
    {
        Wonde.Client client = null;
        public RoomService(string token)
        {
            client = new Wonde.Client(token);
        }

        //return All Schools
        public async Task<Wonde.ResultIterator> GetAll(string schoolId = null)
        {
            return string.IsNullOrEmpty(schoolId) ? client.schools.rooms.all() : client.school(schoolId).rooms.all();
        }

        public async Task<object> Get(string id)
        {
            return client.schools.rooms.get(id);
        }
    }
}
