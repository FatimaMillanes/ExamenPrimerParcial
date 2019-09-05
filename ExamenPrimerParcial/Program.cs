using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPrimerParcial
{
    class Program
    {
        static void Main(string[] args)
        {
            //para Constructor 1
            Peliculas peliculas1 = new Peliculas();

            peliculas1.Titulo = "Interestellar";
            peliculas1.AñoEstreno = 2017;
            peliculas1.Genero= "Sci-fi";
            peliculas1.PaisOrigen= "Estados Unidos";
            peliculas1.Duracion = 140;
            peliculas1.Rating = 9.5;
            peliculas1.Sinopsis= "Hombre viaja al espacio";

            //para Constructor 2

            List<Playlists> playlists = new List<Playlists>();

            Playlists favoritas = new Playlists("favoritas","pelis fav");
            favoritas.Titulo = "Peliculas Favoritas";
            favoritas.Descripcion = "Playlist de mis peliculas favoritas";


            favoritas.playlistpelicula.Add(
                new Peliculas("Shrek", 1955,"genero1","pais1",123,5,"sinopsis1"));
            favoritas.playlistpelicula.Add(
                new Peliculas("Capitan America", 2016, "genero2", "pais2", 132, 6, "sinopsis2"));
            favoritas.playlistpelicula.Add(
                new Peliculas("Iron Man", 2014, "genero3", "pais3", 165, 2, "sinopsis3"));
            favoritas.playlistpelicula.Add(
                new Peliculas("Shrek", 2011, "genero4", "pais4", 123, 9, "sinopsis4"));
            favoritas.playlistpelicula.Add(
                new Peliculas("Shadow", 1965, "genero5", "pais5", 165, 9, "sinopsis5"));
            favoritas.playlistpelicula.Add(
                new Peliculas("Ghost", 2014, "genero6", "pais6", 125, 6, "sinopsis6"));
            favoritas.playlistpelicula.Add(
                new Peliculas("Million miles", 2015, "genero7", "pais7", 132, 3, "sinopsis7"));



            Playlists netflix = new Playlists("netflix","pelis netflix");
            netflix.Titulo = "Peliculas de Netflix";
            netflix.Descripcion = "Playlist de peliculas de netflix que quiero ver";

            netflix.playlistpelicula.Add(
                new Peliculas("La bella y la besstia", 2010, "genero8", "pais8", 132, 5, "sinopsis8"));
            netflix.playlistpelicula.Add(
                new Peliculas("Aladdin", 2018, "genero9", "pais9", 175, 3, "sinopsis9"));
            netflix.playlistpelicula.Add(
                new Peliculas("Barbie", 1966, "genero10", "pais10", 123, 9, "sinopsis10"));
            netflix.playlistpelicula.Add(
                new Peliculas("El rey leon", 1932, "genero11", "pais11", 110, 9, "sinopsis11"));
            netflix.playlistpelicula.Add(
                new Peliculas("La sirenita", 2016, "genero12", "pais12", 132, 6, "sinopsis12"));
            netflix.playlistpelicula.Add(
                new Peliculas("Planeta del tesoro", 1934, "genero13", "pais13", 196, 2, "sinopsis13"));
            netflix.playlistpelicula.Add(
                new Peliculas("Dumbo", 2018, "genero14", "pais14", 146, 3, "sinopsis14"));





            playlists.Add(favoritas);
            playlists.Add(netflix);

            //para imprimir

            foreach (Playlists playlist in playlists)
            {
                Console.WriteLine("*" + playlist.Titulo + " - " + playlist.Descripcion);

                foreach (Peliculas pelicula in playlist.playlistpelicula)
                {
                    Console.WriteLine("Título: " + pelicula.Titulo + " Año: " + pelicula.AñoEstreno);
                }

            }



       
            Console.Read();
        }
    }
}
