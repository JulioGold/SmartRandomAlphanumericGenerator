using System;
using System.Linq;
using System.Text;

namespace SmartRandomAlphanumericGenerator
{
    /// <inheritdoc />
    public class SRAGenerator : ISRAGenerator
    {
        private static Random _random = new Random();
        private const string NUMBERS = "0123456789";
        private const string UPPERCASE_LETTERS = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string LOWERCASE_LETTERS = "abcdefghijklmnopqrstuvwxyz";
        private const string SYMBOLS = "#$@&*$!^%";

        /// <inheritdoc />
        public bool UseNumbers { get; set; } = true;

        /// <inheritdoc />
        public bool UseUppercaseLetters { get; set; } = true;

        /// <inheritdoc />
        public bool UseLowercaseLetters { get; set; } = true;

        /// <inheritdoc />
        public bool UseSymbols { get; set; } = true;

        /// <inheritdoc />
        public string Numbers => NUMBERS;

        /// <inheritdoc />
        public string LowercaseLetters => LOWERCASE_LETTERS;

        /// <inheritdoc />
        public string UppercaseLetters => UPPERCASE_LETTERS;

        /// <inheritdoc />
        public string Symbols => SYMBOLS;

        /// <inheritdoc />
        public string Generate(int size)
        {
            if (size < 1)
            {
                throw new ArgumentOutOfRangeException("You need to pass a positive value.");
            }

            return new string(Enumerable.Repeat(DefineCharactersToUse(), size).Select(character => character[_random.Next(character.Length)]).ToArray());
        }

        private string DefineCharactersToUse()
        {
            if (!UseNumbers && !UseUppercaseLetters & !UseLowercaseLetters & !UseSymbols)
            {
                throw new ArgumentOutOfRangeException("It is necessary a set of characters to generate.");
            }

            StringBuilder sb = new StringBuilder();

            if (UseNumbers)
            {
                sb.Append(NUMBERS);
            }

            if (UseUppercaseLetters)
            {
                sb.Append(UPPERCASE_LETTERS);
            }

            if (UseLowercaseLetters)
            {
                sb.Append(LOWERCASE_LETTERS);
            }

            if (UseSymbols)
            {
                sb.Append(SYMBOLS);
            }

            return sb.ToString();
        }
    }
}