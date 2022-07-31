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
    public class SchoolService : ISchoolService
    {
        string urlBase { get; set; } = "https://api.wonde.com/v1.0/";

        public SchoolService()
        {

        }

        //return All Schools
        public async Task<SchoolModel> GetAll(string accessToken, schoolStatus schoolStatus)
        {
            using (var _ApiConnection = new ApiConnection(urlBase))
            {
                _ApiConnection.Client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");
                _ApiConnection.Client.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", string.Format("Bearer {0}", accessToken));

                HttpResponseMessage response = null;
                switch (schoolStatus)
                {
                    case schoolStatus.Approved:
                        {
                            response = await _ApiConnection.Client.GetAsync("schools");
                            break;
                        }
                    default:
                        {
                            response = await _ApiConnection.Client.GetAsync(string.Format("schools/{0}", WondeApiServices.Helpers.Helper.GetDescription(schoolStatus)));
                            break;
                        }
                }

                var data = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<SchoolModel>(data);
                }
            }
            return null;
        }

        public async Task<SchoolModelSingle> Get(string accessToken,string id)
        {
            using (var _ApiConnection = new ApiConnection(urlBase))
            {
                _ApiConnection.Client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");
                _ApiConnection.Client.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", string.Format("Bearer {0}", accessToken));

                var response = await _ApiConnection.Client.GetAsync(string.Format("schools/{0}", id));
                var data = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<SchoolModelSingle>(data);
                }
            }
            return null;
        }        

    }
}
