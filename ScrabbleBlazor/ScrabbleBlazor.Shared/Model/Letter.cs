namespace ScrabbleBlazor.Shared.Model
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Letter
    {
        public char Value { get; set; }

        public int Score { get; set; }

        public Letter(char value, int score)
        {
            this.Value = value;
            this.Score = score;
        }
    }
}
