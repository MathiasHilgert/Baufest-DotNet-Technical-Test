using System.Collections.Generic;
using System.Linq;

namespace Ingreso.AlphabetSoup
{
    public class WordSearcher
    {
        private char[][] soup;

        public WordSearcher(char[][] soup)
        {
            this.soup = soup;
        }

        /// <summary>
        ///     <para>
        ///         Genera automáticamente los puntos vecinos de un determinado punto de origen, 
        ///         procurando que los mismos se encuentren dentro del rango de la sopa de letras. 
        ///     </para>
        ///     
        ///     <para>
        ///         Los puntos vecinos pueden ser horizontales o verticales, nunca diagonales.
        ///     </para>
        /// </summary>
        /// 
        /// <param name="rootPoint">
        ///     El punto de raíz, es decir, al cual hay que encontrar sus cercanos.
        /// </param>
        ///
        /// <returns>
        ///     Conjunto de puntos vecinos o cercanos.
        /// </returns>
        private IEnumerable<SoupPoint> SearchSoupPointNeighbours(SoupPoint rootPoint)
        {
            return new[]{
                // Generamos los puntos vecinos del punto raíz.

                // Vecino izquierdo.
                new SoupPoint(
                    letter: ' ',
                    x: rootPoint.X - 1,
                    y: rootPoint.Y
                ),

                // Vecino derecho.
                new SoupPoint(
                    letter: ' ',
                    x: rootPoint.X + 1,
                    y: rootPoint.Y
                ),

                // Vecino de arriba.
                new SoupPoint(
                    letter: ' ',
                    x: rootPoint.X,
                    y: rootPoint.Y - 1
                ),

                // Vecino de abajo.
                new SoupPoint(
                    letter: ' ',
                    x: rootPoint.X,
                    y: rootPoint.Y + 1
                ),

            }.Where(neighbor =>
                // Filtramos aquellos vecinos que se encuentran dentro del rango de la sopa de letras.
                neighbor.X >= 0
                && neighbor.X < soup.Length
                && neighbor.Y >= 0
                && neighbor.Y < soup[0].Length

            // Asignamos las letras a cada uno de los vecinos.
            ).Select(neighbor =>
                new SoupPoint(
                    letter: soup[neighbor.X][neighbor.Y],
                    x: neighbor.X,
                    y: neighbor.Y
                )
            );
        }

        /**
         * El objetivo de este ejercicio es implementar una función que determine si una palabra está en una sopa de letras.
         *
         * ### Reglas
         * - Las palabras pueden estar dispuestas direcciones horizontal o vertical, NUNCA en diagonal.
         * - Las palabras pueden estar orientadas en cualquier sentido, esto es, de derecha a izquierda o viceversa, y de arriba para abajo o viceversa.
         * - El cambio de dirección puede estar a media palabra, de modo que, por ejemplo, parte de la palabra esté horizontal y de izquierda a derecha, parte esté vertical y de arriba hacia abajo, y otra parte horizontal de derecha a la izquierda.
         *
         * @param word	Palabra a buscar en la sopa de letras.
         *
         * @return {@link Boolean}	true si la palabra se encuentra
         * en la sopa de letras.
         * */
        public bool IsPresent(string word)
        {
            // Separamos la palabra en cada una de sus letras.
            var letters = word.ToCharArray();

            // Transformar la sopa de letras en una lista de puntos.
            var soupPoints = this.soup.SelectMany((row, x) =>
                row.Select((letter, y) =>
                    new SoupPoint(
                        letter: letter,
                        x: x,
                        y: y
                    )
                )
            );

            /*
                Lo que hay que hacer ahora es buscar aquellos puntos que coincidan con la primera letra de la palabra.
                Esto facilitará la búsqueda de la palabra, declarando puntos de inicio de búsqueda.
            */
            var startPoints = soupPoints.Where(point =>
                point.Letter == letters[0]
            );

            // Buscamos la palabra en cada punto de inicio de búsqueda.
            bool wordFound = false;

            foreach (var startPoint in startPoints)
            {
                // Si la palabra ya fue encontrada...
                if (wordFound)
                    break;

                wordFound = SearchWord(
                    letters: letters,
                    actualIndex: 1,
                    actualPoint: startPoint
                );
            }

            return wordFound;
        }

        /// <summary>
        ///     Busca una palabra en una sopa de letras, partiendo de un punto de origen, ideada para su uso mediante recursividad.
        /// </summary>
        ///
        /// <param name="letters">
        ///     La palabra a buscar en la sopa de letras, en forma de array de letras.
        /// </param>
        ///
        /// <param name="actualIndex">
        ///     El índice de la letra actual de la palabra a buscar.
        /// </param>
        ///
        /// <param name="actualPoint">
        ///     El punto de origen de la búsqueda.
        /// </param>
        ///
        /// <returns>
        ///     Si la palabra fue encontrada desde el punto de origen dado.
        /// </returns>
        private bool SearchWord(char[] letters, int actualIndex, SoupPoint actualPoint)
        {
            // Esta es una función de uso recursivo para explorar si los puntos vecinos a este punto coinciden con la letra de la palabra.

            // Si ya se encontró la palabra...
            if (actualIndex == letters.Length)
            {
                return true;
            }

            // Obtenemos los puntos vecinos del punto actual.
            IEnumerable<SoupPoint> neighbors = SearchSoupPointNeighbours(actualPoint);

            // Buscamos la letra de la palabra en los puntos vecinos.
            bool letterFound = neighbors.Any(neighbor =>
                neighbor.Letter == letters[actualIndex]
            );

            // Si la letra no fue encontrada, la palabra no fue encontrada.
            if (!letterFound)
            {
                return false;
            }

            // Si la letra fue encontrada, buscamos la palabra en los puntos vecinos.
            return neighbors.Any(neighbor =>
                SearchWord(
                    letters: letters,
                    actualIndex: actualIndex + 1,
                    actualPoint: neighbor
                )
            );
        }

    }


}