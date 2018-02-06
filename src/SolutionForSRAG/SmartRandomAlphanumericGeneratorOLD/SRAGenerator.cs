using System;
using System.Linq;
using System.Text;

namespace SmartRandomAlphanumericGenerator
{
    /// <summary>
    /// SmartRandomAlphanumericGenerator.
    /// </summary>
    public class SRAGenerator
    {
        private static Random _random = new Random();
        private const string NUMBERS = "0123456789";
        private const string UPPERCASE_LETTERS = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string LOWERCASE_LETTERS = "abcdefghijklmnopqrstuvwxyz";
        private const string SYMBOLS = "#$@&*$!^%";

        /// <summary>
        /// Define if use numbers.
        /// </summary>
        public bool UseNumbers { get; set; } = true;

        /// <summary>
        /// Define if use uppercase letters.
        /// </summary>
        public bool UseUppercaseLetters { get; set; } = true;

        /// <summary>
        /// Define if use lowercase letters.
        /// </summary>
        public bool UseLowercaseLetters { get; set; } = true;

        /// <summary>
        /// Define if use symbols.
        /// </summary>
        public bool UseSymbols { get; set; } = true;

        public string Numbers => NUMBERS;

        public string LowercaseLetters => LOWERCASE_LETTERS;

        public string UppercaseLetters => UPPERCASE_LETTERS;

        public string Symbols => SYMBOLS;
        
        /// <summary>
        /// Generate a alphanumeric random string with the wanted size.
        /// </summary>
        /// <param name="size">Size of string to generate.</param>
        /// <returns></returns>
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
