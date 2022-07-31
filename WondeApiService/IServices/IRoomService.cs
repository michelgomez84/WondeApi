using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WondeApiModel;

namespace WondeApiServices.IServices
{
    public interface IRoomService
    {
        Task<RoomsModel> GetAll(string accessToken, string schoolId);
        Task<RoomsModelSingle> Get(string accessToken, string schoolId, string id);
    }
}
