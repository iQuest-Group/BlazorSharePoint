namespace ScrabbleBlazor.Shared.Model
{
    using System.Collections.Generic;

    public class Player
    {
        private readonly LetterSet GameLetters;
        public List<Letter> OwnLetters { get; private set; }

        public Player(LetterSet letterSet)
        {
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
