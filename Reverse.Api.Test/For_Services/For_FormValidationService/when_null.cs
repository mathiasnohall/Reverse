using NUnit.Framework;
using Reverse.Api.Services;

namespace Reverse.Api.Test.For_Services.For_FormValidationService
{
    [TestFixture]
    public class when_null
    {
        private IFormValidationService _validationService;

        public when_null()
        {
            _validationService = new FormValidationService();
        }

        [Test]
        public void for_FormValidationService_when_null_it_should_return_empty_string()
        {
            var result = _validationService.GetInputString(null);

            Assert.AreEqual("", result);
        }
    }
}
