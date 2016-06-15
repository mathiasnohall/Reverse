using NUnit.Framework;
using Reverse.Api.Services;

namespace Reverse.Api.Test.For_Services.For_StringReverseService
{
    [TestFixture]
    public class when_null
    {
        private IStringReverseService _reverseService;

        public when_null()
        {
            _reverseService = new StringReverseService();
        }

        [Test]
        public void for_StringReverseService_when_null_it_should_return_empty_string()
        {
            var result = _reverseService.Reverse(null);

            Assert.AreEqual("", result);
        }
    }

}
