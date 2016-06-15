using FakeItEasy;
using NUnit.Framework;
using Reverse.Api.Controllers.Reverse;
using Reverse.Api.Services;
using System.Web.Http.Results;

namespace Reverse.Api.Test.For_Controllers.For_ReverseController
{
    [TestFixture]
    public class when_Reverse
    {
        private ReverseController _controller;
        private IStringReverseService _stringReverseService;
        private IFormValidationService _formValidationService;
        dynamic _formData;

        public when_Reverse()
        {
            _stringReverseService = A.Fake<IStringReverseService>();
            _formValidationService = A.Fake<IFormValidationService>();
            A.CallTo(() => _formValidationService.GetInputString(A<object>.Ignored)).Returns("test");
            _controller = new ReverseController(_stringReverseService, _formValidationService);

            _formData = new { inputString = "test" };
        }

        [Test]
        public void for_ReverseController_when_Reverse_it_should_return_ok()
        {
            var result = _controller.PostReverse(_formData) as OkNegotiatedContentResult<string>;

            Assert.NotNull(result);
        }

        [Test]
        public void for_ReverseController_when_Reverse_it_should_call_stringReverseService()
        {
            var result = _controller.PostReverse(_formData) as OkNegotiatedContentResult<string>;

            A.CallTo(() => _stringReverseService.Reverse(A<string>.Ignored)).MustHaveHappened();
        }

        [Test]
        public void for_ReverseController_when_Reverse_it_should_call_FormValidationService()
        {
            var result = _controller.PostReverse(_formData) as OkNegotiatedContentResult<string>;

            A.CallTo(() => _formValidationService.GetInputString(A<object>.Ignored)).MustHaveHappened();
        }
    }
}
