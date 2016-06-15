using NUnit.Framework;
using Reverse.Api.Services;

namespace Reverse.Api.Test.For_Services.For_StringReverseService
{
    [TestFixture]
    public class when_empty
    {
        private IStringReverseService _reverseService;

        public when_empty()
        {
            _reverseService = new StringReverseService();
        }

        [Test]
        public void for_StringReverseService_when_empty_it_should_return_empty_string()
        {
            var result = _reverseService.Reverse("");

            Assert.AreEqual("", result);
        }
    }
}
