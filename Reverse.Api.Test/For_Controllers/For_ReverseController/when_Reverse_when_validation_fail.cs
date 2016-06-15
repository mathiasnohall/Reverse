using FakeItEasy;
using NUnit.Framework;
using Reverse.Api.Controllers.Reverse;
using Reverse.Api.Services;
using System.Web.Http.Results;

namespace Reverse.Api.Test.For_Controllers.For_ReverseController
{
    [TestFixture]
    public class when_Reverse_when_validation_fail
    {
        private ReverseController _controller;
        private IStringReverseService _stringReverseService;
        private IFormValidationService _formValidationService;

        public when_Reverse_when_validation_fail()
        {
            _stringReverseService = A.Fake<IStringReverseService>();
            _formValidationService = A.Fake<IFormValidationService>();

            A.CallTo(() => _formValidationService.GetInputString(A<object>.Ignored)).Returns("");

            _controller = new ReverseController(_stringReverseService, _formValidationService);
            
        }

        [Test]
        public void for_ReverseController_when_Reverse_when_validation_fail_it_should_return_badrequest()
        {
            var result = _controller.PostReverse(new { }) as BadRequestResult;

            Assert.NotNull(result);
        }
    }
}
