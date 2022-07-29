using System;

namespace SearchByPatternInText
{
    public static class Searcher
    {
        /// <summary>
        /// Searches the pattern string inside the text and collects information about all hit positions in the order they appear.
        /// </summary>
        /// <param name="text">Source text.</param>
        /// <param name="pattern">Source pattern text.</param>
        /// <param name="overlap">Flag to overlap:
        /// if overlap flag is true collect every position overlapping included,
        /// if false no overlapping is allowed (next search behind).</param>
        /// <returns>List of positions of occurrence of the pattern string in the text, if any and empty otherwise.</returns>
        /// <exception cref="ArgumentException">Thrown if text or pattern is null.</exception>
        public static int[] SearchPatternString(this string? text, string? pattern, bool overlap)
        {
            if (text is null)
            {
                throw new ArgumentException("Text is null.", nameof(text));
            }

            if (pattern is null)
            {
                throw new ArgumentException("Pattern is null.", nameof(pattern));
            }

            List<int> hitPositions = new List<int>();

            int i = 0;
            while (i < text.Length)
            {
                i = text.IndexOf(pattern, i, StringComparison.InvariantCultureIgnoreCase);
                if (i == -1)
                {
                    break;
                }

                hitPositions.Add(i + 1);
                if (overlap || pattern.Length == 0)
                {
                    i++;
                }
                else
                {
                    i += pattern.Length;
                }
            }

            return hitPositions.ToArray();
        }
    }
}
