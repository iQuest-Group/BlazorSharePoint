using ScrabbleBlazor.Server.Models;
using ScrabbleBlazor.Shared;
using System.Collections.Generic;

namespace ScrabbleBlazor.Server.Services
{
    public class CurrentStateService
    {
        public static CurrentState _currentState = new CurrentState();

        public static void Initialize()
        {
            _currentState.Table.Matrix[0, 0] = new TableSquare { Letter = 'S' };
            _currentState.Table.Matrix[0, 1] = new TableSquare { Letter = 'T' };
            _currentState.Table.Matrix[0, 2] = new TableSquare { Letter = 'A' };
            _currentState.Table.Matrix[0, 3] = new TableSquare { Letter = 'R' };
            _currentState.Table.Matrix[0, 4] = new TableSquare { Letter = 'T' };

            _currentState.Players.Add(new Player("Andreea", new List<Letter>
            {
                new Letter { Value = 'A' },
                new Letter { Value = 'Z' }
            })
            { IsCurrentPlayer = true }
            );

            _currentState.Players.Add(new Player("Dan", new List<Letter>
            {
                new Letter { Value = 'B' },
                new Letter { Value = 'I' }
            }));

            _currentState.Players.Add(new Player("Luci", new List<Letter>
            {
                new Letter { Value = 'T' },
                new Letter { Value = 'D' }
            }));

            _currentState.Players.Add(new Player("Paula", new List<Letter>
            {
                new Letter { Value = 'O' },
                new Letter { Value = 'N' }
            }));
        }

        public static CurrentState GetCurrentState()
        {
            return _currentState;
        }

        public static void Update(string identifier)
        {
            foreach (var player in _currentState.Players)
            {
                player.IsCurrentPlayer = player.Identifier == identifier;
            }
        }
    }
}
