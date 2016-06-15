using NUnit.Framework;
using Reverse.Api.Services;

namespace Reverse.Api.Test.For_Services.For_FormValidationService
{
    [TestFixture]
    public class when_validData
    {
        private IFormValidationService _validationService;
        dynamic _form;

        public when_validData()
        {
            _form = new { inpuString = "test test test" };
            _validationService = new FormValidationService();
        }

        [Test]
        public void for_FormValidationService_when_validData_it_should_return_inputSting()
        {
            var result = _validationService.GetInputString(_form);

            Assert.AreEqual("test test test", result);
        }
    }
}
