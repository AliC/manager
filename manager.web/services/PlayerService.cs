using System.Collections.Generic;
using manager.web.Controllers;

namespace manager.web.services
{
    public class PlayerService : IPlayerService
    {
        private readonly IPlayerRepository _repository;

        public PlayerService(IPlayerRepository repository)
        {
            _repository = repository;
        }

        public IList<Player> List()
        {
            return _repository.List();
        }
    }
}