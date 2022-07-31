using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WondeApiModel;

namespace WondeApiServices.IServices
{
    public interface IPeriodService
    {
        Task<PeriodsModel> GetAll(string accessToken, string schoolId);
        Task<PeriodsModelSingle> Get(string accessToken, string schoolId, string id);
    }
}
