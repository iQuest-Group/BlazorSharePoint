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

        public TableSquare(string letter)
        {
            this.Letter = letter;
        }

        public string Letter { get; set; } 
    }
}
