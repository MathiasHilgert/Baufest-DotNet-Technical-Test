namespace Ingreso.AlphabetSoup
{
    /// <summary>
    ///     Estructura que representa un punto específico de la sopa de letras.
    /// </summary>
    public struct SoupPoint
    {
        public int X { get; set; }
        public int Y { get; set; }
        public char Letter { get; set; }

        public SoupPoint(char letter, int x, int y)
        {
            Letter = letter;
            X      = x;
            Y      = y;
        }
    }
}