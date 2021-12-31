using System;
using System.Collections.Generic;
using System.Linq;

namespace Ingreso.Sorting
{
    public class Sorting
    {

        /**
         * Se debe ordenar primero por puntuación de manera descendente, luego por nombre de manera ascendente.
         * @param jugadores la lista de jugadores a ordenar
         * @return la lista ordenada de jugadores
         */
        public static List<Jugador> OrdenarPorPuntuacionYNombre(List<Jugador> jugadores)
        {
            // Verificaciones de ahorro... nunca están de más :)
            if (jugadores == null)
            {
                throw new ArgumentNullException();
            }

            if (jugadores.Count == 0)
            {
                return new List<Jugador>();
            }

            if (jugadores.Count == 1)
            {
                return jugadores;
            }

            // Ordenamiento
            return jugadores.OrderByDescending(x => x.Puntuacion)
                            .ThenBy(x => x.Nombre)
                            .ToList();
        }

        /**
         * Se debe ordenar primero por puntuación de manera descendente. Cuando 2 jugadores tienen igual cantidad de puntos,
         * el que tiene menos perdidas se lo considerara el mayor. Luego a igual puntos y perdidas se seguirá usando el
         * nombre de manera ascendente.
         * @param jugadores la lista de jugadores a ordenar
         * @return la lista ordenada de jugadores
         */
        public static List<Jugador> OrdenarPorPuntuacionPerdidasYNombre(List<Jugador> jugadores)
        {
            // Verificaciones de ahorro... nunca están de más :)
            if (jugadores == null)
            {
                throw new ArgumentNullException();
            }

            if (jugadores.Count == 0)
            {
                return new List<Jugador>();
            }

            if (jugadores.Count == 1)
            {
                return jugadores;
            }

            // Ordenamiento
            return jugadores.OrderByDescending(x => x.Puntuacion)
                        .ThenBy(x => x.Perdidas)
                        .ThenBy(x => x.Nombre)
                        .ToList();
        }
    }
}