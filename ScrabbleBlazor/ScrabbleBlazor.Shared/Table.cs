using System;
using System.Collections.Generic;
using System.Text;

namespace ScrabbleBlazor.Shared
{
    public class Table
    {
        private TableSquare[,] table = new TableSquare[15, 15];

        public TableSquare[,] Matrix
        {
            get
            {
                return table;
            }
        }

        //public GetSquare(line, columns)
        //{
        //    return table[line][column]
        //}
    }
}
