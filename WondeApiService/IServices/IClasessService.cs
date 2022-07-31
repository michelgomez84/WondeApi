using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WondeApiModel;

namespace WondeApiServices.IServices
{
    public interface IClasessService
    {
        Task<StudentClassModel> GetAll(string accessToken, string schoolId);
        Task<StudentClassModelSingle> Get(string accessToken, string schoolId, string id);
    }
}
