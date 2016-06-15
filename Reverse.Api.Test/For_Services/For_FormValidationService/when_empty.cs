using NUnit.Framework;
using Reverse.Api.Services;

namespace Reverse.Api.Test.For_Services.For_FormValidationService
{
    [TestFixture]
    public class when_empty
    {
        private IFormValidationService _validationService;
        dynamic _form;

        public when_empty()
        {
            _form = new { inputString = "" };
            _validationService = new FormValidationService();
        }

        [Test]
        public void for_FormValidationService_when_empty_it_should_return_empty_string()
        {
            var result = _validationService.GetInputString(_form);

            Assert.AreEqual("", result);
        }
    }
}
