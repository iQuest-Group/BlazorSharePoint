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
