using System;
using System.Collections.Generic;
using System.Text;

namespace ScrabbleBlazor.Shared
{
    public class Table
    {
        public Table()
        {
            Squares = new List<List<TableSquare>>();
        }

        public void Initialize()
        {
            for (int i = 0; i < 15; i++)
            {
                List<TableSquare> row = new List<TableSquare>();

                for (int j = 0; j < 15; j++)
                {
                    row.Add(new TableSquare(null));
                }

                Squares.Add(row);
            }
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