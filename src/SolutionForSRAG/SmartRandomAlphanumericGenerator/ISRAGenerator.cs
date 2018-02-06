namespace SmartRandomAlphanumericGenerator
{
    /// <summary>
    /// Generates text with chosen alphanumeric characters.
    /// </summary>
    public interface ISRAGenerator
    {
        /// <summary>
        /// String of lowercase letters.
        /// </summary>
        string LowercaseLetters { get; }

        /// <summary>
        /// String of uppercase letters.
        /// </summary>
        string UppercaseLetters { get; }

        /// <summary>
        /// String of numbers.
        /// </summary>
        string Numbers { get; }

        /// <summary>
        /// String of symbols.
        /// </summary>
        string Symbols { get; }

        /// <summary>
        /// Define if use lowercase letters.
        /// </summary>
        bool UseLowercaseLetters { get; set; }

        /// <summary>
        /// Define if use numbers.
        /// </summary>
        bool UseNumbers { get; set; }

        /// <summary>
        /// Define if use symbols.
        /// </summary>
        bool UseSymbols { get; set; }

        /// <summary>
        /// Define if use uppercase letters.
        /// </summary>
        bool UseUppercaseLetters { get; set; }

        /// <summary>
        /// Generate a alphanumeric random string with the wanted size.
        /// </summary>
        /// <param name="size">Size of string to generate.</param>
        /// <returns></returns>
        string Generate(int size);
    }
}