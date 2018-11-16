namespace ScrabbleBlazor.Shared
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class LetterSet
    {
        public List<Letter> AllLetters { get; set; }

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

        public void InitializeLetterSet()
        {

        }
    }
}
