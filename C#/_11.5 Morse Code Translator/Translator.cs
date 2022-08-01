using System;
using System.Text;

namespace MorseCodeTranslator
{
    public static class Translator
    {
        public static string TranslateToMorse(string? message)
        {
            StringBuilder sb = new StringBuilder();
            WriteMorse(MorseCodes.CodeTable, message, sb);
            return sb.ToString();
        }

        public static string TranslateToText(string? morseMessage)
        {
            StringBuilder sb = new StringBuilder();
            WriteText(MorseCodes.CodeTable, morseMessage, sb);
            return sb.ToString();
        }

        public static void WriteMorse(char[][]? codeTable, string? message, StringBuilder? morseMessageBuilder, char dot = '.', char dash = '-', char separator = ' ')
        {
            if (codeTable is null)
            {
                throw new ArgumentNullException(nameof(codeTable));
            }

            if (message is null)
            {
                throw new ArgumentNullException(nameof(message));
            }

            if (morseMessageBuilder is null)
            {
                throw new ArgumentNullException(nameof(morseMessageBuilder));
            }

            if (message.Length == 0)
            {
                return;
            }

            for (int i = 0; i < message.Length; i++)
            {
                char[] code = FindMorseCode(codeTable, message[i], dot, dash);
                if (code.Length != 0)
                {
                    morseMessageBuilder.Append(code);
                    morseMessageBuilder.Append(separator);
                }
            }

            morseMessageBuilder.Remove(morseMessageBuilder.Length - 1, 1);
        }

        public static void WriteText(char[][]? codeTable, string? morseMessage, StringBuilder? messageBuilder, char dot = '.', char dash = '-', char separator = ' ')
        {
            if (codeTable is null)
            {
                throw new ArgumentNullException(nameof(codeTable));
            }

            if (morseMessage is null)
            {
                throw new ArgumentNullException(nameof(morseMessage));
            }

            if (messageBuilder is null)
            {
                throw new ArgumentNullException(nameof(messageBuilder));
            }

            string[] codes = morseMessage.Split(separator);

            for (int i = 0; i < codes.Length; i++)
            {
                messageBuilder.Append(FindChar(codeTable, codes[i], dot, dash));
            }
        }

        private static char[] FindMorseCode(char[][] codeTable, char c, char dot = '.', char dash = '-')
        {
            for (int i = 0; i < codeTable.Length; i++)
            {
                if (char.ToUpperInvariant(c) == codeTable[i][0])
                {
                    char[] code = codeTable[i][1..];
                    code.ChangeCodeToCustom(dot, dash);
                    return code;
                }
            }

            return Array.Empty<char>();
        }

        private static char? FindChar(char[][] codeTable, string morseCode, char dot = '.', char dash = '-')
        {
            for (int i = 0; i < codeTable.Length; i++)
            {
                char[] code = codeTable[i][1..];
                code.ChangeCodeToCustom(dot, dash);
                if (morseCode.Equals(new string(code), StringComparison.Ordinal))
                {
                    return codeTable[i][0];
                }
            }

            return null;
        }

        private static void ChangeCodeToCustom(this char[] code, char dot, char dash)
        {
            for (int i = 0; i < code.Length; i++)
            {
                if (code[i] == '.')
                {
                    code[i] = dot;
                }
                else if (code[i] == '-')
                {
                    code[i] = dash;
                }
            }
        }
    }
}
