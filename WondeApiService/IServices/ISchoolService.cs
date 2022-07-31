using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WondeApiModel;

namespace WondeApiServices.IServices
{
    public interface ISchoolService
    {
        Task<SchoolModel> GetAll(string accessToken, schoolStatus schoolStatus);
        Task<SchoolModelSingle> Get(string accessToken, string id);
    }
}
