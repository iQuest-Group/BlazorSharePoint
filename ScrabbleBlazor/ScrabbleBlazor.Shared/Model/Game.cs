using System.Collections.Generic;
using System.Threading.Tasks;

namespace ScrabbleBlazor.Shared.Model
{
    public class Game
    {
        public List<Player> Players { get; set; }

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

        public async Task<Player> EnsurePlayer(string identifier)
        {
            foreach(Player player in this.Players)
            {
                if (player.Identifier.Equals(identifier))
                {
                    if (string.IsNullOrEmpty(CurrentPlayer))
                    {
                        CurrentPlayer = player.Identifier;
                    }

                    return player;
                }
            }

            if (this.Players.Count < PlayerConstants.NumberOfPlayers)
            {
                var player = new Player(identifier, this.LettersBag.GetRandomLetters(PlayerConstants.NumberOfPlayerLetters));
                this.Players.Add(player);
                return player;
            }

            return null;           
        }

        public async Task RemoveFromOwnLetter(Player player, string wordCreated)
        {
            foreach(char c in wordCreated)
            {
                var letterFound = player.OwnLetters.Find(x => x.Value==c);
                player.OwnLetters.Remove(letterFound);
            }
        }

        public async Task AddRandomLetters(Player player, int numberOfLetters)
        {
            player.OwnLetters.AddRange(this.LettersBag.GetRandomLetters(numberOfLetters));
        }

        public async Task SelectNextPlayer(Player player)
        {
            if (Players.Count > 1)
            {
                for(int i=0;i<Players.Count;i++)
                {
                    if (player.Identifier.Equals(Players[i].Identifier) && Players.Count > 1)
                    {
                        if (i < Players.Count - 1)
                        {
                            CurrentPlayer = Players[i+1].Identifier;
                            return;
                        }
                        else
                        {
                            CurrentPlayer = Players[0].Identifier;
                            return;
                        }
                    }
                }
            }
            
        }
    }
}
