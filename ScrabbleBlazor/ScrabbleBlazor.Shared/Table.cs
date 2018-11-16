using System;
using System.Collections.Generic;
using System.Text;

namespace ScrabbleBlazor.Shared
{
    public class Table
    {
        public Table()
        {

        }

        public List<List<TableSquare>> Squares
        {
            get;
            set;
        }

        public int PlayerCount { get; set; }

        //public GetSquare(line, columns)
        //{
        //    return table[line][column]
        //}
    }
}