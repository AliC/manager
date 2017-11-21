using System.Web.Mvc;
using manager.web.Controllers;
using NUnit.Framework;

namespace manager.web.tests.Controllers
{
    [TestFixture]
    public class PlayerControllerTests
    {
        [Test]
        public void Should_List_Players()
        {
            IPlayerService playerService = new PlayerService();
            var controller = new PlayerController(playerService);

            ViewResult actualResult = controller.List() as ViewResult;

            Assert.IsNotNull(actualResult);
        }
    }
}
