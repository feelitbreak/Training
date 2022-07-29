using System;
using System.Text;

namespace LanguageGame
{
    public static class Translator
    {
        private static readonly char[] AlphabetAndApostrophe =
            {
            'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
            'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
            'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '’',
            };

        /// <summary>
        /// Translates from English to Pig Latin. Pig Latin obeys a few simple following rules:
        /// - if word starts with vowel sounds, the vowel is left alone, and most commonly 'yay' is added to the end;
        /// - if word starts with consonant sounds or consonant clusters, all letters before the initial vowel are
        ///   placed at the end of the word sequence. Then, "ay" is added.
        /// Note: If a word begins with a capital letter, then its translation also begins with a capital letter,
        /// if it starts with a lowercase letter, then its translation will also begin with a lowercase letter.
        /// </summary>
        /// <param name="phrase">Source phrase.</param>
        /// <returns>Phrase in Pig Latin.</returns>
        /// <exception cref="ArgumentException">Thrown if phrase is null or empty.</exception>
        /// <example>
        /// "apple" -> "appleyay"
        /// "Eat" -> "Eatyay"
        /// "explain" -> "explainyay"
        /// "Smile" -> "Ilesmay"
        /// "Glove" -> "Oveglay".
        /// </example>
        public static string TranslateToPigLatin(string phrase)
        {
            if (string.IsNullOrWhiteSpace(phrase))
            {
                throw new ArgumentException("Phrase is null or empty or white space.", nameof(phrase));
            }

            StringBuilder sb = new StringBuilder(phrase.Length);

            int i = 0;
            while (i < phrase.Length)
            {
                int prevInd = i;
                i = phrase.IndexOfAny(AlphabetAndApostrophe, prevInd);

                if (i == -1)
                {
                    sb.Append(phrase.AsSpan(prevInd, phrase.Length - prevInd));
                    return sb.ToString();
                }

                sb.Append(phrase.AsSpan(prevInd, i - prevInd));

                int length = 1;
                while (i + length != phrase.Length && phrase.IndexOfAny(AlphabetAndApostrophe, i + length) == i + length)
                {
                    length++;
                }

                string translation = TranslateWord(phrase.Substring(i, length));
                sb.Append(translation);

                i += length;
            }

            return sb.ToString();
        }

        private static string TranslateWord(string word)
        {
            if (word[0].IsVowel())
            {
                return word + "yay";
            }

            int firstVowelInd = word.IndexOfAny(new char[] { 'a', 'e', 'i', 'o', 'u' });

            if (firstVowelInd == -1)
            {
                return word + "ay";
            }

            string wordCons = word[.. firstVowelInd];

            StringBuilder sb = new StringBuilder(word);
            sb.Remove(0, wordCons.Length);

            if (char.IsUpper(word[0]))
            {
                sb[0] = char.ToUpperInvariant(sb[0]);
                wordCons = char.ToLowerInvariant(wordCons[0]) + wordCons[1..];
            }

            sb.Append(wordCons);
            sb.Append("ay");
            return sb.ToString();
        }

        private static bool IsVowel(this char c)
        {
            return c switch
            {
                'a' or 'A' or 'e' or 'E' or 'i' or 'I' or 'o' or 'O' or 'u' or 'U' => true,
                _ => false
            };
        }
    }
}
