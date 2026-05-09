using Microsoft.AspNetCore.Mvc;
namespace MODUL10_103022400054
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController
    {
        private static List<Games> games = new List<Games>() {

        new Games {Nama = "Valorant", Developer = "Riot Games", TahunRilis = 2020, Genre = "FPS",
        Rating = 8.5, Platform = ["PC"], Mode = ["Multiplayer"], IsOnline = true, Harga = 0},

        new Games {Nama = "GTA V", Developer = "Rockstar Games", TahunRilis = 2013, Genre = "Open World", Rating = 9.5, Platform = ["PC"], Mode = ["Singleplayer",
        "Multiplayer"], IsOnline = true, Harga = 300000},

        new Games {Nama = "The Witcher 3", Developer = "CD Projekt Red", TahunRilis = 2015, Genre = "RPG", Rating = 9.7, Platform = ["PC"], Mode = ["Singleplayer"], IsOnline = false, Harga = 250000}
        };

        [HttpGet]
        public ActionResult<List<Games>> GetAllGames()
        {
            return games;
        }

        [HttpGet("{id}")]
        public ActionResult<Games> GetById(int id)
        {
            var game = games.FirstOrDefault(g => g.id == id);
            return (game);
        }

        [HttpPost]
        public ActionResult<Games> AddGame(Games newGame)
        {
            games.Add(newGame);
            return newGame;
        }

        [HttpPut]
        public ActionResult UpdateGame(int id, Games updatedGame)
        {
            var index = games.FirstOrDefault(g => g.id == id);


            games[index] = updatedGame;

        }
    [HttpDelete]
        public ActionResult DeleteGame(int id)
        {           
            games.RemoveAt(id);
            return Ok();
        }
    }

}

