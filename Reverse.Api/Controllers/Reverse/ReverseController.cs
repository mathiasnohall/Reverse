using System.Web.Http;

namespace Reverse.Api.Controllers.Reverse
{
    public class ReverseController : ApiController
    {
        public ReverseController()
        {

        }

        [HttpPost]
        public IHttpActionResult PostReverse([FromBody] dynamic form)
        {
            return Ok("test");
        }
    }
}