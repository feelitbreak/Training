using System;
using System.IO;

namespace Streams
{
    public static class ReadingFromString
    {
        public static string ReadAllStreamContent(StringReader stringReader)
        {
            return stringReader.ReadToEnd();
        }

        public static string ReadCurrentLine(StringReader stringReader)
        {
            return stringReader.ReadLine() !;
        }

        public static bool ReadNextCharacter(StringReader stringReader, out char currentChar)
        {
            int res = stringReader.Read();
            if (res == -1)
            {
                currentChar = ' ';
                return false;
            }
            else
            {
                currentChar = Convert.ToChar(res);
                return true;
            }
        }

        public static bool PeekNextCharacter(StringReader stringReader, out char currentChar)
        {
            int res = stringReader.Peek();
            if (res == -1)
            {
                currentChar = ' ';
                return false;
            }
            else
            {
                currentChar = Convert.ToChar(res);
                return true;
            }
        }

        public static char[] ReadCharactersToBuffer(StringReader stringReader, int count)
        {
            char[] result = new char[count];
            stringReader.ReadBlock(result, 0, count);
            return result;
        }
    }
}
