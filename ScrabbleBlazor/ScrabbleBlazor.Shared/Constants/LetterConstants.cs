namespace ScrabbleBlazor.Shared.Constants
{
    using System;
    using System.Collections.Generic;

    public static class LetterConstants
    {
        public static List<Tuple<char, int, int>> LettersGame = new List<Tuple<char, int, int>>()
        {
            new Tuple<char, int, int>('A', 1, 11),
            new Tuple<char, int, int>('B', 9, 2),
            new Tuple<char, int, int>('C', 1, 5),
            new Tuple<char, int, int>('D', 2, 4),
            new Tuple<char, int, int>('E', 1, 9),
            new Tuple<char, int, int>('F', 8, 2),
            new Tuple<char, int, int>('G', 9, 2),
            new Tuple<char, int, int>('H', 10, 1),
            new Tuple<char, int, int>('I', 1, 10),
            new Tuple<char, int, int>('J', 10, 1),
            new Tuple<char, int, int>('L', 1, 4),
            new Tuple<char, int, int>('M', 4, 3),
            new Tuple<char, int, int>('N', 1, 6),
            new Tuple<char, int, int>('O', 1, 5),
            new Tuple<char, int, int>('P', 2, 4),
            new Tuple<char, int, int>('R', 1, 7),
            new Tuple<char, int, int>('S', 1, 5),
            new Tuple<char, int, int>('T', 1, 7),
            new Tuple<char, int, int>('U', 1, 6),
            new Tuple<char, int, int>('V', 8, 2),
            new Tuple<char, int, int>('X', 10, 1),
            new Tuple<char, int, int>('Z', 10, 1),
            new Tuple<char, int, int>('*', 0, 2),

        };
    }
}
