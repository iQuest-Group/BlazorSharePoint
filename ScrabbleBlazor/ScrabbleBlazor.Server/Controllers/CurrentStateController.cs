using Microsoft.AspNetCore.Mvc;
using ScrabbleBlazor.Server.Services;
using ScrabbleBlazor.Shared;
using ScrabbleBlazor.Shared.Constants;
using ScrabbleBlazor.Shared.Model;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

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

        [HttpPost]
        public async Task<IEnumerable<Game>> Post([FromBody] IEnumerable<Game> games)
        {
            var gameInstance = Game.Instance;
            gameInstance = games.ToList()[0];
            return null;
        }

        public async Task<Player> Register(string identifier)
        {
            return await Game.Instance.EnsurePlayer(identifier);
        }

        public async Task SubmitWord(string identifier, string word)
        {
            var player = await Game.Instance.EnsurePlayer(identifier);
            await Game.Instance.RemoveFromOwnLetter(player, word);
            await Game.Instance.AddRandomLetters(player, PlayerConstants.NumberOfPlayerLetters - player.OwnLetters.Count);
            await Game.Instance.SelectNextPlayer(player);
        }
    }
}