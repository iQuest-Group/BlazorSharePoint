namespace ScrabbleBlazor.Shared.Model
{
    public class Game
    {
        public Player[] Players { get; }

        public LetterSet LettersBag { get; }

        public Game()
        {
            this.LettersBag = new LetterSet();
            this.Players = new Player[PlayerConstants.NumberOfPlayers];
            for(int i=0;i<this.Players.Length;i++)
            {
                this.Players[i] = new Player(LettersBag);
            }
        }
    }
}
