using System;
using System.Collections.Generic;
using System.Text;

namespace ScrabbleBlazor.Shared
{
    [Serializable]
    public class TableSquare
    {
        public TableSquare()
        {

        }

        public TableSquare(char? letter)
        {
            this.Letter = letter;
        }

        public char? Letter { get; set; } 
    }
}
