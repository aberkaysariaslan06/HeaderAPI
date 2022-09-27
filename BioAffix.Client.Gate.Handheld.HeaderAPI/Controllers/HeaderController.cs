using BioAffix.Client.Gate.Handheld.HeaderAPI.Model;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BioAffix.Client.Gate.Handheld.HeaderAPI.Controllers
{
    [ApiController]
    [Route("API/[controller]")]
    public class HeaderController : ControllerBase
    {

        public HeaderController()
        {
        }

        [HttpGet]
        public string Get()
        {
            return string.Join("\r\n", Request.Headers.Select(x => x.Value).ToList());
        }
    }
}