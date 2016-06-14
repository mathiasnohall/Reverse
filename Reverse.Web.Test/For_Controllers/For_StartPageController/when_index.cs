using NUnit.Framework;
using Reverse.Web.Controllers;
using Reverse.Web.ViewModels.Pages;
using System.Web.Mvc;

namespace Reverse.Web.Test.For_Controllers.For_StartPageController
{
    [TestFixture]
    public class when_index
    {
        private StartPageController _controller;

        public when_index()
        {
            _controller = new StartPageController();
        }

        [Test]
        public void for_StartPageController_when_index_it_should_return_a_pageviewmodel()
        {
            var viewResult = _controller.Index() as ViewResult;
            var model = viewResult.Model as PageViewModel;

            Assert.NotNull(model);
        }
    }
}
