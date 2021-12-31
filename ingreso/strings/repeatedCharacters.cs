using System;
using System.Linq;
using System.Collections.Generic;

namespace Ingreso.Strings
{
    public class RepeatedCharacters
    {
        /**
         * El metodo debe retornar un booleano indicando si el parametro `cadena` cumple con alguna de las siguientes propiedades:
         * 1- Todos los caracteres aparecen la misma cantidad de veces.
         *     Ejemplos: "aabbcc", "abcdef", "aaaaaa"
         * 2- Todos los caracteres aparecen la misma cantidad de veces, a excepcion de 1, que aparece un vez mas o una vez menos.
         *     Ejemplos: "aabbccc", "aabbc", "aaaaccccc"
         * Tener en cuenta que el parametro `cadena` puede contener espacios en blanco.
         * @param cadena la cadena a evaluar
         * @return booleano indicando si la cadena cumple con las propiedades
         */
        public bool IsValid(string cadena)
        {
            // Verificaciones de ahorro... nunca están de más :)
            if (cadena == null)
            {
                throw new ArgumentNullException();
            }

            if (cadena.Length == 0)
            {
                return true;
            }

            // Obtengo la cantidad de caracteres que aparecen en la cadena.
            Dictionary<char, int> cantidadCaracteres = cadena.GroupBy(c => c).ToDictionary(keySelector: g => g.Key, elementSelector: g => g.Count());

            // Obtengo el valor mínimo y máximo de los caracteres que aparecen en la cadena.
            int min = cantidadCaracteres.Min(c => c.Value);
            int max = cantidadCaracteres.Max(c => c.Value);

            return (
                // Primer condición: Todos los caracteres aparecen la misma cantidad de veces.
                min == max ||
                
                // Segunda condición: Todos los caracteres aparecen la misma cantidad de veces, a excepcion de 1, que aparece una vez mas o una vez menos.
                (min + 1 == max || min - 1 == max)
            );
        }
    }
}
