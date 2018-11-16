using ScrabbleBlazor.Shared;
using ScrabbleBlazor.Shared.Model;
using System.Collections.Generic;

namespace ScrabbleBlazor.Server.Models
{
    public class CurrentState
    {
        public Game Game { get { return Game.Instance; } }
    }
}
