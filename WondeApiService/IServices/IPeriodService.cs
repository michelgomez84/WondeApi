using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WondeApiServices.IServices
{
    public interface IPeriodService
    {
        Task<Wonde.ResultIterator> GetAll(string schoolId = null);
        Task<object> Get(string id);
    }
}
