using Microsoft.AspNetCore.Mvc;

namespace projet_ASP.Controllers
{
    public class GameController : Controller
    {
        private readonly GameService _gameService;

        public GameController()
        {
            _gameService = new GameService();
        }
        public IActionResult Index()
        {
            var games = _gameService.GetGames();
            return View(games);
        }

        public IActionResult Details(int id)
        {
            var game = _gameService.GetGame(id);
            return View(game);
        }

        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(Game game)
        {
            game.Id = _gameService.GetGames().Max(g => g.Id) + 1;
            _gameService.AddGame(game);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var game = _gameService.GetGame(id);
            return View(game);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _gameService.DeleteGame(id);
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
              var game = _gameService.GetGame(id);
            return View(game);
        }

        [HttpPost]
        public IActionResult Edit(Game game)
        {
            var gameToEdit = _gameService.GetGame(game.Id);
            gameToEdit.Titre = game.Titre;
            gameToEdit.AnneeSortie = game.AnneeSortie;
            gameToEdit.Genre = game.Genre;
            gameToEdit.Resume = game.Resume;
            return RedirectToAction("Index");
        }

        










    }
}
