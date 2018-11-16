namespace ScrabbleBlazor.Shared.Model
{
    using System.Collections.Generic;

    public class Player
    {
        public string Identifier { get; set; }
        
        public List<Letter> OwnLetters { get; set; }

        public Player()
        {

        }

        public Player(string identifier, List<Letter> letters)
        {
            this.Identifier = identifier;
            this.OwnLetters = letters;
        }

        public Letter GetSelectedLetter()
        {
           foreach(Letter letter in this.OwnLetters)
            {
            }
        }
    }
}
