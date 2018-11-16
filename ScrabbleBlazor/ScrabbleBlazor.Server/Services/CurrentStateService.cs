using ScrabbleBlazor.Server.Models;
using ScrabbleBlazor.Shared;
using ScrabbleBlazor.Shared.Model;
using System.Collections.Generic;

namespace ScrabbleBlazor.Server.Services
{
    public class CurrentStateService
    {
        public static CurrentState _currentState = new CurrentState();

        public static void Initialize()
        {
            _currentState.Game.Table.Matrix[0, 0] = new TableSquare { Letter = 'S' };
            _currentState.Game.Table.Matrix[0, 1] = new TableSquare { Letter = 'T' };
            _currentState.Game.Table.Matrix[0, 2] = new TableSquare { Letter = 'A' };
            _currentState.Game.Table.Matrix[0, 3] = new TableSquare { Letter = 'R' };
            _currentState.Game.Table.Matrix[0, 4] = new TableSquare { Letter = 'T' };
        }

        public static CurrentState GetCurrentState()
        {
            return _currentState;
        }

        public static void Update(string identifier)
        {
            //foreach (var player in _currentState.Players)
            //{
            //   // player.IsCurrentPlayer = player.Identifier == identifier;
            //}
        }
    }
}
