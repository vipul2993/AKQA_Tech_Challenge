using Services;
using Services.Interface;
using System.Web.Http;

namespace Challenge.Controllers
{
    public class ConvertController : ApiController
    {

        private readonly IChallenge _challenge;

        public ConvertController(IChallenge challenge)
        {
            _challenge = challenge;
        }


        [Route("api/convert")]
        [HttpPost]
        public string GetWords(string number)
        {
            return _challenge.ConvertToWords(number);
        }




    }
}