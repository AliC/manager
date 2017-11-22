using System.Collections.Generic;
using manager.web.Controllers;
using manager.web.services;
using Moq;
using NUnit.Framework;

namespace manager.web.tests.services
{
    [TestFixture]
    public class PlayerServiceTests
    {
        [Test]
        public void Should_Return_Player_List()
        {
            IList<Player> expectedPlayers = new List<Player> { new Player { Name = "Marco Van Basten" } };

            IPlayerRepository repository = Mock.Of<IPlayerRepository>();
            Mock.Get(repository).Setup(r => r.List()).Returns(expectedPlayers);

            IPlayerService service = new PlayerService(repository);
            IList<Player> actualPlayers = service.List();

            Assert.IsNotNull(actualPlayers);
            CollectionAssert.AreEqual(actualPlayers, expectedPlayers);
        }
    }
}
