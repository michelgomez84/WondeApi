using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WondeApiModel;

namespace WondeApiServices.IServices
{
    public interface IEmployesService
    {
        Task<EmployeModel> GetAll(string accessToken, string schoolId);
        Task<EmployeModelSingle> Get(string accessToken, string schoolId, string id);
    }
}
