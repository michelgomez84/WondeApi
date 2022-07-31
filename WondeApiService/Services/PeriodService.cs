using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WondeApiModel;
using WondeApiServices.Helpers;
using WondeApiServices.IServices;

namespace WondeApiServices.Services
{    
    public class PeriodService : IPeriodService
    {
        string urlBase { get; set; } = "https://api.wonde.com/v1.0/";

        public PeriodService()
        {

        }

        //return All Schools
        public async Task<PeriodsModel> GetAll(string accessToken, string schoolId)
        {
            using (var _ApiConnection = new ApiConnection(urlBase))
            {
                _ApiConnection.Client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");
                _ApiConnection.Client.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", string.Format("Bearer {0}", accessToken));

                var response = await _ApiConnection.Client.GetAsync(string.Format("schools/{0}/periods", schoolId));

                var data = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<PeriodsModel>(data);
                }
            }
            return null;
        }

        public async Task<PeriodsModelSingle> Get(string accessToken, string schoolId, string id)
        {
            using (var _ApiConnection = new ApiConnection(urlBase))
            {
                _ApiConnection.Client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");
                _ApiConnection.Client.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", string.Format("Bearer {0}", accessToken));

                var response = await _ApiConnection.Client.GetAsync(string.Format("schools/{0}/periods/{1}", schoolId, id));

                var data = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<PeriodsModelSingle>(data);
                }
            }
            return null;
        }


    }

}
