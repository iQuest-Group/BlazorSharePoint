namespace ScrabbleBlazor.Shared.Model
{
    using ScrabbleBlazor.Shared.Constants;
    using System;
    using System.Collections.Generic;

    public class LetterSet
    {
        public List<Letter> AllLetters { get; set; }

        public LetterSet()
        {
            this.InitializeLetterSet();
        }

        public List<Letter> GetRandomLetters(int numberOfExpectedLetters)
        {
            var random = new Random();
            List<Letter> extractedLettersArray = new List<Letter>();
            for (int i = 0; i < numberOfExpectedLetters; i++)
            {
                int index = random.Next(AllLetters.Count);
                Letter extractedLetter = AllLetters[index];
                extractedLettersArray.Add(extractedLetter);
                AllLetters.RemoveAt(index);
            }

            return extractedLettersArray;
        }

        public int GetNumberOfAvailableLetters()
        {
            return AllLetters.Count;
        }

        private void InitializeLetterSet()
        {
            this.AllLetters = new List<Letter>();
            foreach(var letterConstant in LetterConstants.LettersGame)
            {
                var letter = new Letter(letterConstant.Item1, letterConstant.Item2);
                for (int i = 0; i < letterConstant.Item3;i++)
                {
                    this.AllLetters.Add(letter);
                }
            }
        }
    }
}
