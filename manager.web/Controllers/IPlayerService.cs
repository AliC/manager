using System.Collections.Generic;

namespace manager.web.Controllers
{
    public interface IPlayerService
    {
        IList<Player> List();
    }
}