using System;
using System.IO;
using System.Text;

namespace Streams
{
    public static class ReadingFromStream
    {
        public static string ReadAllStreamContent(StreamReader streamReader)
        {
            return streamReader.ReadToEnd();
        }

        public static string[] ReadLineByLine(StreamReader streamReader)
        {
            List<string> result = new List<string>();

            string? line;
            while ((line = streamReader.ReadLine()) != null)
            {
                result.Add(line);
            }

            return result.ToArray();
        }

        public static StringBuilder ReadOnlyLettersAndNumbers(StreamReader streamReader)
        {
            StringBuilder sb = new StringBuilder();

            int readRes;
            char c;
            while ((readRes = streamReader.Peek()) != -1 && char.IsLetterOrDigit(Convert.ToChar(readRes)))
            {
                c = Convert.ToChar(streamReader.Read());
                sb.Append(c);
            }

            return sb;
        }

        public static char[][] ReadAsCharArrays(StreamReader streamReader, int arraySize)
        {
            List<char[]> result = new List<char[]>();

            while (streamReader.Peek() != -1)
            {
                char[] array = new char[arraySize];
                int i = 0;
                for (; i < arraySize && streamReader.Peek() != -1; i++)
                {
                    array[i] = Convert.ToChar(streamReader.Read());
                }

                if (i != arraySize)
                {
                    Array.Resize(ref array, i);
                }

                result.Add(array);
            }

            return result.ToArray();
        }
    }
}
