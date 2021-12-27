using System;

namespace Ingreso.AlphabetSoup
{

    public class WordSearcher
    {

        private char[][] soup;

        public WordSearcher(char[][] soup)
        {
            this.soup = soup;
        }

        /**
         * El objetivo de este ejercicio es implementar una función que determine si una palabra está en una sopa de letras.
         *
         * ### Reglas
         * - Las palabras pueden estar dispuestas direcciones horizontal o vertical, _no_ en diagonal.
         * - Las palabras pueden estar orientadas en cualquier sentido, esto es, de derecha a izquierda o viceversa, y de arriba
         * para abajo o viceversa.
         * - El cambio de dirección puede estar a media palabra, de modo que, por ejemplo, parte de la palabra
         * esté horizontal y de izquierda a derecha, parte esté vertical y de arriba hacia abajo, y otra parte horizontal
         * de derecha a la izquierda.
         *
         * @param word	Palabra a buscar en la sopa de letras.
         *
         * @return {@link Boolean}	true si la palabra se encuentra
         * en la sopa de letras.
         * */
        public bool IsPresent(string word)
        {
            //TODO: resolver
            throw new NotImplementedException();
        }
    }
}