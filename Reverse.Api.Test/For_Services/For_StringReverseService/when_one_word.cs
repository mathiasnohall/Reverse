using NUnit.Framework;
using Reverse.Api.Services;

namespace Reverse.Api.Test.For_Services.For_StringReverseService
{
    [TestFixture]
    public class when_one_word
    {
        private IStringReverseService _reverseService;

        public when_one_word()
        {
            _reverseService = new StringReverseService();
        }

        [Test]
        public void for_StringReverseService_when_one_word_it_should_return_reversed_word()
        {
            var result = _reverseService.Reverse("test");

            Assert.AreEqual("tset", result);
        }
    }

}
