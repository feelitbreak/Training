using System;

namespace Anagrams
{
    public class Anagram
    {
        private readonly string word;
        private readonly char[] sortedUpperWordArray;

        /// <summary>
        /// Initializes a new instance of the <see cref="Anagram"/> class.
        /// </summary>
        /// <param name="sourceWord">Source word.</param>
        /// <exception cref="ArgumentNullException">Thrown when source word is null.</exception>
        /// <exception cref="ArgumentException">Thrown when  source word is empty.</exception>
        public Anagram(string? sourceWord)
        {
            if (sourceWord is null)
            {
                throw new ArgumentNullException(nameof(sourceWord));
            }

            if (sourceWord.Length == 0)
            {
                throw new ArgumentException("The source word is empty", nameof(sourceWord));
            }

            this.word = sourceWord;
            this.sortedUpperWordArray = this.word.ToUpperInvariant().ToCharArray();
            Array.Sort(this.sortedUpperWordArray);
        }

        /// <summary>
        /// From the list of possible anagrams selects the correct subset.
        /// </summary>
        /// <param name="candidates">A list of possible anagrams.</param>
        /// <returns>The correct sublist of anagrams.</returns>
        /// <exception cref="ArgumentNullException">Thrown when candidates list is null.</exception>
        public string[] FindAnagrams(string[]? candidates)
        {
            if (candidates is null)
            {
                throw new ArgumentNullException(nameof(candidates));
            }

            List<string> result = new List<string>();
            for (int i = 0; i < candidates.Length; i++)
            {
                if (this.IsAnagram(candidates[i]))
                {
                    result.Add(candidates[i]);
                }
            }

            return result.ToArray();
        }

        private bool IsAnagram(string candidate)
        {
            if (this.word.Length != candidate.Length)
            {
                return false;
            }

            if (this.word.ToUpperInvariant() == candidate.ToUpperInvariant())
            {
                return false;
            }

            char[] candidateArray = candidate.ToUpperInvariant().ToCharArray();
            Array.Sort(candidateArray);

            for (int i = 0; i < candidateArray.Length; i++)
            {
                if (char.ToUpperInvariant(candidateArray[i]) != this.sortedUpperWordArray[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
