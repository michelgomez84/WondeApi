using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WondeApiModel;

namespace WondeApiServices.IServices
{
    public interface ILessonService
    {
        Task<LessonModel> GetAll(string accessToken, string schoolId);
        Task<LessonModelSingle> Get(string accessToken, string schoolId, string id);
    }
}
