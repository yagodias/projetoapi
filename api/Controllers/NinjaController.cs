using api.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NinjaController : ControllerBase
    {

        private static List<Ninja> _ninjas = new List<Ninja>();



        [HttpGet]
        public ActionResult getNinja (string nome)
        {
            var ninja = _ninjas.FirstOrDefault(n => n.Nome == nome);

            return Ok(ninja);
        }

        [HttpPost]
        public ActionResult postNinja(Ninja ninja)
        {

            _ninjas.Add(ninja);


            return Ok();
        }
    }
}
