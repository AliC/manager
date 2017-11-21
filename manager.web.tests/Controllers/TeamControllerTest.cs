using System.Web.Mvc;
using manager.web.Controllers;
using NUnit.Framework;

namespace manager.web.tests.Controllers
{
    [TestFixture]
    public class TeamControllerTests
    {
        [Test]
        public void Create_Team_Request_Should_Return_Create_Team_View()
        {
            var controller = new TeamController();

            ViewResult actualResult = controller.Create() as ViewResult;

            Assert.IsNotNull(actualResult);
        }


        [Ignore("Consider selenium tests")]
        public void ViewTest()
        {
            Assert.AreEqual("Create", "ViewBag.Title");
        }
    }
}
