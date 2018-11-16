using System;
using System.Collections.Generic;
using System.Text;

namespace ScrabbleBlazor.Shared
{
    public class Player
    {
        public List<Letter> OwnLetters { get; set; }

        public Player(List<Letter> letters)
        {
            this.OwnLetters = letters;
        }

    }
}
