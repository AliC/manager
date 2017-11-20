using System.Web.Mvc;
using manager.web.Controllers;
using NUnit.Framework;

namespace manager.web.tests.Controllers
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            var controller = new TeamController();

            ViewResult actualResult = controller.Create() as ViewResult;

            Assert.IsNotNull(actualResult);
        }
    }
}
