using NUnit.Framework;
using Reverse.Api.Controllers.Reverse;
using System.Web.Http.Results;

namespace Reverse.Api.Test.For_Controllers.For_ReverseController
{
    [TestFixture]
    public class when_Reverse
    {
        private ReverseController _controller;
        dynamic _formData;

        public when_Reverse()
        {
            _controller = new ReverseController();

            _formData = new { };
        }

        [Test]
        public void for_ReverseController_when_Reverse_it_should_return_ok()
        {
            var result = _controller.PostReverse(_formData) as OkResult;

            Assert.NotNull(result);
        }
    }
}
