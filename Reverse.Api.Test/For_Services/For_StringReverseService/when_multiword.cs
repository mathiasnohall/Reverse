using NUnit.Framework;
using Reverse.Api.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse.Api.Test.For_Services.For_StringReverseService
{
    [TestFixture]
    public class when_multiword
    {
        private IStringReverseService _reverseService;

        public when_multiword()
        {
            _reverseService = new StringReverseService();
        }

        [Test]
        public void for_StringReverseService_when_multiword_it_should_return_reversed_words_in_reverse()
        {
            var result = _reverseService.Reverse("hej jag heter mathias");

            Assert.AreEqual("saihtam reteh gaj jeh", result);
        }
    }

}
