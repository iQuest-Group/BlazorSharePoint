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

        public string ChangePlayer(string identifier)
        {
            CurrentStateService.Update(identifier);

            return "done";
        }

        public async Task<Player> Register(string identifier)
        {
            return await Game.Instance.RegisterPlayer(identifier);
        }
    }
}