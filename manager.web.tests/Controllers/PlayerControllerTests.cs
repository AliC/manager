using System.Web.Mvc;
using manager.web.Controllers;
using manager.web.services;
using Moq;
using NUnit.Framework;

namespace manager.web.tests.Controllers
{
    [TestFixture]
    public class PlayerControllerTests
    {
        [Test]
        public void Should_List_Players()
        {
            IPlayerService playerService = Mock.Of<IPlayerService>();
            var controller = new PlayerController(playerService);

            ViewResult actualResult = controller.List() as ViewResult;

            Assert.IsNotNull(actualResult);
        }
    }
}
