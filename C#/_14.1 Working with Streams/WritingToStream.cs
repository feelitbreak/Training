using System;
using System.Globalization;
using System.IO;
using System.Text;

namespace Streams
{
    public static class WritingToStream
    {
        public static void ReadAndWriteIntegers(StreamReader streamReader, StreamWriter outputWriter)
        {
            while (streamReader.Peek() != -1)
            {
                int integer = streamReader.Read();
                outputWriter.Write(integer);
            }
        }

        public static void ReadAndWriteChars(StreamReader streamReader, StreamWriter outputWriter)
        {
            while (streamReader.Peek() != -1)
            {
                char c = Convert.ToChar(streamReader.Read());
                outputWriter.Write(c);
            }

            outputWriter.Flush();
        }

        public static void TransformBytesToHex(StreamReader contentReader, StreamWriter outputWriter)
        {
            while (contentReader.Peek() != -1)
            {
                int integer = contentReader.Read();
                outputWriter.Write("{0:X2}", integer);
            }
        }

        public static void WriteLinesWithNumbers(StreamReader contentReader, StreamWriter outputWriter)
        {
            int i = 1;
            while (contentReader.Peek() != -1)
            {
                outputWriter.Write("{0:D3}", i);
                outputWriter.Write(' ');
                outputWriter.WriteLine(contentReader.ReadLine());

                i++;
            }

            outputWriter.Flush();
        }

        public static void RemoveWordsFromContentAndWrite(StreamReader contentReader, StreamReader wordsReader, StreamWriter outputWriter)
        {
            StringBuilder content = new StringBuilder(contentReader.ReadToEnd());

            while (wordsReader.Peek() != -1)
            {
                string word = wordsReader.ReadLine() !;
                content.Replace(word, string.Empty);
            }

            outputWriter.Write(content);
        }
    }
}
