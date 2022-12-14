using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WondeApiModel;

namespace WondeApiServices.IServices
{
    public interface IStudentService
    {
        Task<StudentModel> GetAll(string accessToken, string schoolId);
        Task<StudentModelSingle> Get(string accessToken, string schoolId, string id);
    }
}
