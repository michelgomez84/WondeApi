using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WondeApiServices.IServices
{
    public interface ISchoolService
    {
        Task<Wonde.ResultIterator> GetAll();
        Task<Wonde.EndPoints.Schools> Get(string id);
    }
}
