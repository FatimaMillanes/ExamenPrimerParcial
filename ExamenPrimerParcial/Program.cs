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
                new Peliculas("Shrek", 1955,"","",123,5,""));
            favoritas.playlistpelicula.Add(
                new Peliculas("Capitan America", 2016, "", "", 132, 6, ""));
            favoritas.playlistpelicula.Add(
                new Peliculas("Iron Man", 2014, "", "", 165, 2, ""));
            favoritas.playlistpelicula.Add(
                new Peliculas("Shrek", 2011, "", "", 123, 9, ""));
            favoritas.playlistpelicula.Add(
                new Peliculas("Shadow", 1965, "", "", 165, 9, ""));
            favoritas.playlistpelicula.Add(
                new Peliculas("Ghost", 2014, "", "", 125, 6, ""));
            favoritas.playlistpelicula.Add(
                new Peliculas("Million miles", 2015, "", "", 132, 3, ""));



            Playlists netflix = new Playlists("netflix","pelis netflix");
            netflix.Titulo = "Peliculas de Netflix";
            netflix.Descripcion = "Playlist de peliculas de netflix que quiero ver";

            netflix.playlistpelicula.Add(
                new Peliculas("La bella y la besstia", 2010, "", "", 132, 5, ""));
            netflix.playlistpelicula.Add(
                new Peliculas("Aladdin", 2018, "", "", 175, 3, ""));
            netflix.playlistpelicula.Add(
                new Peliculas("Barbie", 1966, "", "", 123, 9, ""));
            netflix.playlistpelicula.Add(
                new Peliculas("El rey leon", 1932, "", "", 110, 9, ""));
            netflix.playlistpelicula.Add(
                new Peliculas("La sirenita", 2016, "", "", 132, 6, ""));
            netflix.playlistpelicula.Add(
                new Peliculas("Planeta del tesoro", 1934, "", "", 196, 2, ""));
            netflix.playlistpelicula.Add(
                new Peliculas("Dumbo", 2018, "", "", 146, 3, ""));





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
