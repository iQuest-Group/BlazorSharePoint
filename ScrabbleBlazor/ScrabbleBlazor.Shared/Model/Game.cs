using System;
using System.Collections.Generic;
using System.Text;

namespace ScrabbleBlazor.Shared
{
    public class Game
    {
        public Player[] Players { get; }

        public LetterSet LettersBag { get; }

        public Game()
        {
            this.LettersBag = new LetterSet();
            this.Players = new Player[PlayerConstants.NumberOfPlayers];
            foreach(var player in this.Players)
            {
                player.OwnLetters = this.LettersBag.GetRandomLetters(PlayerConstants.NumberOfPlayerLetters);
            }
        }
    }
}
