using Microsoft.AspNetCore.Mvc;
using ScrabbleBlazor.Server.Services;
using ScrabbleBlazor.Shared.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ScrabbleBlazor.Server.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CurrentStateController : ControllerBase
    {
        public IEnumerable<Game> Get()
        {
            return new List<Game> { Game.Instance };
        }

        public void Post(Game game)
        {
            var gameInstance = Game.Instance;
            gameInstance = game;
        }

        public async Task<Player> Register(string identifier)
        {
            return await Game.Instance.EnsurePlayer(identifier);
        }

        public async Task SubmitWord(string identifier, string word)
        {
            var player = await Game.Instance.EnsurePlayer(identifier);
            await Game.Instance.RemoveFromOwnLetter(player, word);
            await Game.Instance.AddRandomLetters(player, word.Length);
        }
    }
}