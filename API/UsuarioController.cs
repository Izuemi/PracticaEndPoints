using Microsoft.AspNetCore.Mvc;

namespace TestAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CrudOperations : ControllerBase
    {

        [HttpGet]
        [Route("GET")]
        public ActionResult<string> Get()
        {
            //var tipito = new RespuestaRutaDos
            //{
            //    Nombre = "pepe",
            //    Edad = 10
            //};

            //return Ok();

            return "Ok - CREATE";
        }

        [HttpPost]
        [Route("POST")]
        public ActionResult<string> Post(string data)
        {
            //return $"Ok Recibi tu data: {data}";

            return "Ok - POST";
        }

        [HttpGet]
        [Route("PUT")]
        public ActionResult<string> Put()
        {
            return "Ok - PUT";
        }

        [HttpGet]
        [Route("DELETE")]
        public ActionResult<string> Delete()
        {
            return "Ok - DELETE";
        }
    }

    public class RespuestaRutaDos
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
    }
}
