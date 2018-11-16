using System.Collections.Generic;

namespace ScrabbleBlazor.Shared.Model
{
    public class Game
    {
        public List<Player> Players { get; }

        public LetterSet LettersBag { get; }

        public string CurrentPlayer { get; set; }

        public Table Table { get; set; }

        private Game()
        {
            this.Table = new Table();
            this.LettersBag = new LetterSet();
            this.Players = new List<Player>();
            
        }

        private static Game instance;

        public static Game Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Game();
                }

                return instance;
            }
        }

        public Player RegisterPlayer(string identifier)
        {
            if (this.Players.Count < PlayerConstants.NumberOfPlayers)
            {
                var player = new Player(identifier, this.LettersBag.GetRandomLetters(PlayerConstants.NumberOfPlayerLetters));
                this.Players.Add(player);
                return player;
            }

            return null;           
        }

        public void RemoveFromOwnLetter(Player player, Letter selectedLetter)
        {
            player.OwnLetters.Remove(selectedLetter);
        }

        public void AddRandomLetters(Player player, int numberOfLetters)
        {
            player.OwnLetters.AddRange(this.LettersBag.GetRandomLetters(numberOfLetters));
        }
    }
}
