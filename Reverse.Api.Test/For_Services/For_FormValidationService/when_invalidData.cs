using NUnit.Framework;
using Reverse.Api.Services;

namespace Reverse.Api.Test.For_Services.For_FormValidationService
{
    [TestFixture]
    public class when_invalidData
    {
        private IFormValidationService _validationService;
        dynamic _form;

        public when_invalidData()
        {
            _form = new { };
            _validationService = new FormValidationService();
        }

        [Test]
        public void for_FormValidationService_when_invalidData_it_should_return_empty_string()
        {
            var result = _validationService.GetInputString(_form);

            Assert.AreEqual("", result);
        }
    }
}
