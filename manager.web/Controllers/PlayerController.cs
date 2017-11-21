using System.Web.Mvc;

namespace manager.web.Controllers
{
    public class PlayerController : Controller
    {
        private IPlayerService _playerService;

        public PlayerController(IPlayerService playerService)
        {
            _playerService = playerService;
        }

        public ActionResult List()
        {
            var players = _playerService.List();

            return View(players);
        }
    }
}