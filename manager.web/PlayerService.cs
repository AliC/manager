using System.Collections.Generic;
using manager.web.Controllers;

namespace manager.web
{
    public class PlayerService : IPlayerService
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