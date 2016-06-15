using Reverse.Api.Services;
using System.Web.Http;

namespace Reverse.Api.Controllers.Reverse
{
    public class ReverseController : ApiController
    {
        private readonly IStringReverseService _stringReverseService;
        private readonly IFormValidationService _formValidationService;

        public ReverseController(IStringReverseService stringReverseService, IFormValidationService formValidationService)
        {
            _stringReverseService = stringReverseService;
            _formValidationService = formValidationService;
        }

        [HttpPost]
        public IHttpActionResult PostReverse([FromBody] dynamic form)
        {
            var inputString = _formValidationService.GetInputString(form);
            if (string.IsNullOrEmpty(inputString))
                return BadRequest();

            var result = _stringReverseService.Reverse(inputString);

            return Ok(result);
        }
    }
}