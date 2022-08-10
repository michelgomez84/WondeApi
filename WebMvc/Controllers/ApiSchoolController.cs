using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WondeApiServices.IServices;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebMvc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiSchoolController : ControllerBase
    {
        ISchoolService _schoolService;

        public ApiSchoolController(ILogger<HomeController> logger, ISchoolService schoolService)
        {
            _schoolService = schoolService;
        }


        [AllowAnonymous]
        [HttpGet("Test")]
        public async Task<string> Test()
        {
            
            return "Hello World";
        }


        // GET: api/<ApiSchoolController>
        [Helpers.Authorize]
        [HttpGet]
        public async Task<WondeApiModel.SchoolModel> Get(string token)
        {
            // LLamamos al servico que retorna lista de escuelas
            // Le pasamos como referencia el ApiToken -> que es el token de acceso que le dan al cliente para consumir el servicio
            // El otro parametro es el school status ... 
            //"82d1a6bd415d77309cc7fb7520ded1eabc9c0682"
            var data = await _schoolService.GetAll(token, WondeApiModel.schoolStatus.All);

            return data;
        }

        // GET api/<ApiSchoolController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ApiSchoolController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ApiSchoolController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ApiSchoolController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }

}
