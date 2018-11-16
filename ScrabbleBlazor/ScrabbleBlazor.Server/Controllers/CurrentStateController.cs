using Microsoft.AspNetCore.Mvc;
using ScrabbleBlazor.Server.Models;
using ScrabbleBlazor.Server.Services;
using ScrabbleBlazor.Shared;
using System.Collections.Generic;

namespace ScrabbleBlazor.Server.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CurrentStateController : ControllerBase
    {
        public CurrentState Get()
        {
            return CurrentStateService.GetCurrentState();
        }

        public string ChangePlayer(string identifier)
        {
            CurrentStateService.Update(identifier);

            return "done";
        }

        //public void Post(string identifier, Table table, List<Letter> playerLetters)
        //{

        //}
    }
}