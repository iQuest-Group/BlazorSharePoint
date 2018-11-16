namespace ScrabbleBlazor.Shared.Model
{
    using System.Collections.Generic;

    public class Player
    {
        public string Identifier { get; set; }

        public bool IsCurrentPlayer { get; set; }

        private readonly LetterSet GameLetters;
        public List<Letter> OwnLetters { get; set; }

        public Player(string identifier, LetterSet letterSet)
        {
            Identifier = identifier;
            this.GameLetters = letterSet;
            this.OwnLetters = letterSet.GetRandomLetters(PlayerConstants.NumberOfPlayerLetters);
        }

        public void RemoveFromOwnLetter(Letter selectedLetter)
        {
            this.OwnLetters.Remove(selectedLetter);
        }

        public void AddRandomLetters(int numberOfLetters)
        {
            this.OwnLetters.AddRange(this.GameLetters.GetRandomLetters(numberOfLetters));
        }
    }
}
