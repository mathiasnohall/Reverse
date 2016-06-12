using System.Web.Http;

namespace Reverse.Api.Controllers.Status
{
    public class StatusController : ApiController
    {

        public IHttpActionResult GetStatus()
        {

            return Ok("ok");
        }
    }
}
