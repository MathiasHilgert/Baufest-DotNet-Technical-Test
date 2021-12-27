using Ingreso.Sorting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace IngresoTest.Sorting
{
    [TestClass]
    public class SortingTest
    {

        [TestMethod]
        public void Sort1Completo()
        {
            Jugador p1 = new Jugador("Matias", 100);
            Jugador p2 = new Jugador("Alejandro", 100);
            Jugador p3 = new Jugador("Enzo", 50);
            Jugador p4 = new Jugador("Junior", 75);
            Jugador p5 = new Jugador("Pablo", 150);
            List<Jugador> jugadores = new List<Jugador>();
            jugadores.Add(p1);
            jugadores.Add(p2);
            jugadores.Add(p3);
            jugadores.Add(p4);
            jugadores.Add(p5);

            List<Jugador> jugadoresResult = Ingreso.Sorting.Sorting.OrdenarPorPuntuacionYNombre(jugadores);

            Jugador p1Sort = new Jugador("Pablo", 150);
            Jugador p2Sort = new Jugador("Alejandro", 100);
            Jugador p3Sort = new Jugador("Matias", 100);
            Jugador p4Sort = new Jugador("Junior", 75);
            Jugador p5Sort = new Jugador("Enzo", 50);
            List<Jugador> jugadoresSort = new List<Jugador>();
            jugadoresSort.Add(p1Sort);
            jugadoresSort.Add(p2Sort);
            jugadoresSort.Add(p3Sort);
            jugadoresSort.Add(p4Sort);
            jugadoresSort.Add(p5Sort);


            Assert.AreEqual(jugadoresSort.Count, jugadoresResult.Count);
            Assert.AreEqual(jugadoresSort[0].Nombre, jugadoresResult[0].Nombre);
            Assert.AreEqual(jugadoresSort[1].Nombre, jugadoresResult[1].Nombre);
            Assert.AreEqual(jugadoresSort[2].Nombre, jugadoresResult[2].Nombre);
            Assert.AreEqual(jugadoresSort[3].Nombre, jugadoresResult[3].Nombre);
            Assert.AreEqual(jugadoresSort[4].Nombre, jugadoresResult[4].Nombre);
        }

        [TestMethod]
        public void Sort1Vacio()
        {
            List<Jugador> jugadores = new List<Jugador>();
            List<Jugador> jugadoresResult = Ingreso.Sorting.Sorting.OrdenarPorPuntuacionYNombre(jugadores);
            Assert.IsTrue(jugadoresResult.Count == 0);
        }

        [TestMethod]
        public void Sort1Unico()
        {
            Jugador p1 = new Jugador("Matias", 100);
            List<Jugador> jugadores = new List<Jugador>();
            jugadores.Add(p1);
            List<Jugador> jugadoresResult = Ingreso.Sorting.Sorting.OrdenarPorPuntuacionYNombre(jugadores);
            Assert.AreEqual(1, jugadoresResult.Count);
            Assert.AreEqual(p1.Nombre, jugadoresResult[0].Nombre);
        }

        [TestMethod]
        public void Sort2Completo()
        {

            Jugador p1 = new Jugador("Matias", 100, 3);
            Jugador p2 = new Jugador("Alejandro", 100, 4);
            Jugador p3 = new Jugador("Enzo", 75, 5);
            Jugador p4 = new Jugador("Junior", 75, 30);
            Jugador p5 = new Jugador("Pablo", 150, 0);
            List<Jugador> jugadores = new List<Jugador>();
            jugadores.Add(p1);
            jugadores.Add(p2);
            jugadores.Add(p3);
            jugadores.Add(p4);
            jugadores.Add(p5);

            List<Jugador> jugadoresResult = Ingreso.Sorting.Sorting.OrdenarPorPuntuacionPerdidasYNombre(jugadores);

            Jugador p1Sort = new Jugador("Pablo", 150, 0);
            Jugador p2Sort = new Jugador("Matias", 100, 3);
            Jugador p3Sort = new Jugador("Alejandro", 100, 4);
            Jugador p4Sort = new Jugador("Enzo", 75, 5);
            Jugador p5Sort = new Jugador("Junior", 75, 30);

            List<Jugador> jugadoresSort = new List<Jugador>();
            jugadoresSort.Add(p1Sort);
            jugadoresSort.Add(p2Sort);
            jugadoresSort.Add(p3Sort);
            jugadoresSort.Add(p4Sort);
            jugadoresSort.Add(p5Sort);


            Assert.AreEqual(jugadoresSort.Count, jugadoresResult.Count);
            Assert.AreEqual(jugadoresSort[0].Nombre, jugadoresResult[0].Nombre);
            Assert.AreEqual(jugadoresSort[1].Nombre, jugadoresResult[1].Nombre);
            Assert.AreEqual(jugadoresSort[2].Nombre, jugadoresResult[2].Nombre);
            Assert.AreEqual(jugadoresSort[3].Nombre, jugadoresResult[3].Nombre);
            Assert.AreEqual(jugadoresSort[4].Nombre, jugadoresResult[4].Nombre);
        }

        [TestMethod]
        public void Sort2Vacio()
        {
            List<Jugador> jugadores = new List<Jugador>();
            List<Jugador> jugadoresResult = Ingreso.Sorting.Sorting.OrdenarPorPuntuacionPerdidasYNombre(jugadores);
            Assert.IsTrue(jugadoresResult.Count == 0);
        }

        [TestMethod]
        public void Sort2Unico()
        {
            Jugador p1 = new Jugador("Matias", 100);
            List<Jugador> jugadores = new List<Jugador>();
            jugadores.Add(p1);
            List<Jugador> jugadoresResult = Ingreso.Sorting.Sorting.OrdenarPorPuntuacionPerdidasYNombre(jugadores);
            Assert.AreEqual(1, jugadoresResult.Count);
            Assert.AreEqual(p1.Nombre, jugadoresResult[0].Nombre);
        }
    }
}
