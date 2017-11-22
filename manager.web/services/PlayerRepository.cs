using System.Collections.Generic;
using manager.web.Controllers;

namespace manager.web.services
{
    public class PlayerRepository : IPlayerRepository
    {
        public IList<Player> List()
        {
            return new List<Player>
            {
                new Player
                {
                    Name = "Kevin De Bruyne"
                }
            };
        }
    }
}