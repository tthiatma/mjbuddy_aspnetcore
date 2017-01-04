using Microsoft.AspNetCore.Mvc;

namespace MjBuddy.Web.Controllers
{
    public class GameController : Controller
    {
        public GameController()
        {

        }
        /// <summary>
        /// User will wait in lobby until game is ready
        /// </summary>
        /// <returns></returns>
        public ViewResult Lobby()
        {
            return View();
        }
        public ViewResult GameRoom()
        {
            return View();
        }

    }
}
