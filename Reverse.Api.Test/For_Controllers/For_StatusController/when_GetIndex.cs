using NUnit.Framework;
using Reverse.Api.Controllers.Status;
using System.Web.Http.Results;

namespace Reverse.Api.Test.For_Controllers.For_StatusController
{
    [TestFixture]
    public class when_GetIndex
    {
        private StatusController _controller;

        public when_GetIndex()
        {
            _controller = new StatusController();
        }

        [Test]
        public void for_StatusController_when_getStatus_it_should_return_status_ok()
        {
            var result = _controller.GetStatus() as OkNegotiatedContentResult<string>;

            Assert.NotNull(result);
        }
    }
}
