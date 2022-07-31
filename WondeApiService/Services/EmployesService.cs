using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using WondeApiModel;
using WondeApiServices.Helpers;
using WondeApiServices.IServices;

namespace WondeApiServices.Services
{
    public class EmployesService : IEmployesService
    {
        string urlBase { get; set; } = "https://api.wonde.com/v1.0/";

        public EmployesService()
        {

        }

        //return All Schools
        public async Task<EmployeModel> GetAll(string accessToken, string schoolId)
        {
            using (var _ApiConnection = new ApiConnection(urlBase))
            {
                _ApiConnection.Client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");
                _ApiConnection.Client.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", string.Format("Bearer {0}", accessToken));

                var response = await _ApiConnection.Client.GetAsync(string.Format("schools/{0}/employees", schoolId));

                var data = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<EmployeModel>(data);
                }
            }
            return null;
        }

        public async Task<EmployeModelSingle> Get(string accessToken, string schoolId, string id)
        {
            using (var _ApiConnection = new ApiConnection(urlBase))
            {
                _ApiConnection.Client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");
                _ApiConnection.Client.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", string.Format("Bearer {0}", accessToken));

                var response = await _ApiConnection.Client.GetAsync(string.Format("schools/{0}/employees/{1}", schoolId, id));

                var data = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<EmployeModelSingle>(data);
                }
            }
            return null;
        }


    }
}
