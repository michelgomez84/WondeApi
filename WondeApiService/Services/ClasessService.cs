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
    public class ClasessService : IClasessService
    {
        string urlBase { get; set; } = "https://api.wonde.com/v1.0/";

        public ClasessService()
        {

        }

        //return All Schools
        public async Task<StudentClassModel> GetAll(string accessToken, string schoolId)
        {
            using (var _ApiConnection = new ApiConnection(urlBase))
            {
                _ApiConnection.Client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");
                _ApiConnection.Client.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", string.Format("Bearer {0}", accessToken));

                var response = await _ApiConnection.Client.GetAsync(string.Format("schools/{0}/classes", schoolId));

                var data = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<StudentClassModel>(data);
                }
            }
            return null;
        }

        public async Task<StudentClassModelSingle> Get(string accessToken, string schoolId, string id)
        {
            using (var _ApiConnection = new ApiConnection(urlBase))
            {
                _ApiConnection.Client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");
                _ApiConnection.Client.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", string.Format("Bearer {0}", accessToken));

                var response = await _ApiConnection.Client.GetAsync(string.Format("schools/{0}/classes/{1}", schoolId, id));

                var data = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<StudentClassModelSingle>(data);
                }
            }
            return null;
        }


    }
}
