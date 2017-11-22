using System.Collections.Generic;
using manager.web.Controllers;

namespace manager.web.services
{
    public interface IPlayerService
    {
        IList<Player> List();
    }
}