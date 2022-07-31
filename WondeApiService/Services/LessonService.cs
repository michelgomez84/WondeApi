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
    public class LessonService : ILessonService
    {
        string urlBase { get; set; } = "https://api.wonde.com/v1.0/";

        public LessonService()
        {

        }

        //return All Schools
        public async Task<LessonModel> GetAll(string accessToken, string schoolId)
        {
            using (var _ApiConnection = new ApiConnection(urlBase))
            {
                _ApiConnection.Client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");
                _ApiConnection.Client.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", string.Format("Bearer {0}", accessToken));

                var response = await _ApiConnection.Client.GetAsync(string.Format("schools/{0}/lessons", schoolId));

                var data = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<LessonModel>(data);
                }
            }
            return null;
        }

        public async Task<LessonModelSingle> Get(string accessToken, string schoolId, string id)
        {
            using (var _ApiConnection = new ApiConnection(urlBase))
            {
                _ApiConnection.Client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");
                _ApiConnection.Client.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", string.Format("Bearer {0}", accessToken));

                var response = await _ApiConnection.Client.GetAsync(string.Format("schools/{0}/lessons/{1}", schoolId, id));

                var data = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<LessonModelSingle>(data);
                }
            }
            return null;
        }


    }
}
