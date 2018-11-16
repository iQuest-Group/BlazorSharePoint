using System;
using System.Collections.Generic;
using System.Text;

namespace ScrabbleBlazor.Shared
{
    public class Player
    {
        public string Identifier { get; set; }

        public bool IsCurrentPlayer { get; set; }

        public List<Letter> OwnLetters { get; set; }

        public Player(string identifier, List<Letter> letters)
        {
            Identifier = identifier;
            OwnLetters = letters;
        }

    }
}
