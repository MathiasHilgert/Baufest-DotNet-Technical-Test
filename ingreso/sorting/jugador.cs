using System;

namespace Ingreso.Sorting
{
    public class Jugador
    {

        public string Nombre { get; set; }
        public int Puntuacion { get; set; }
        public int Perdidas { get; set; }

        public Jugador(String nombre, int puntuacion)
        {
            this.Nombre = nombre;
            this.Puntuacion = puntuacion;
            this.Perdidas = 0;
        }

        public Jugador(String nombre, int puntuacion, int perdidas)
        {
            this.Nombre = nombre;
            this.Puntuacion = puntuacion;
            this.Perdidas = perdidas;
        }
    }
}
