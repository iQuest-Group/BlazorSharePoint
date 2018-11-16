using ScrabbleBlazor.Shared;
using ScrabbleBlazor.Shared.Model;
using System.Collections.Generic;

namespace ScrabbleBlazor.Server.Models
{
    public class CurrentState
    {
        public Table Table { get; } = new Table();

        public List<Player> Players { get; } = new List<Player>();
    }
}
