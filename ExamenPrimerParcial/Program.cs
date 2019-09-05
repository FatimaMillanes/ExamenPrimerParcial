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

            //Fin del Constructor 1

            


            //para Constructor 2
            Peliculas peliculas2= new Peliculas("Gravity",2016,"Sci-fi","Estados Unidos",160,8.6,"Esta chila");
            //Fin del constructor 2




            List<Playlists> playlists = new List<Playlists>();

            Playlists favoritas = new Playlists("favoritas");
            favoritas.Titulo = "Peliculas Favoritas";
            favoritas.Descripcion = "Playlist de mis peliculas favoritas";


            favoritas.Pelicula.Add(
                new Peliculas("Shrek", "Vida de un ogro en un pantano"));
            favoritas.Pelicula.Add(
                new Peliculas("Capitan America", "Vida de un superheroe con un escudo"));
            favoritas.Pelicula.Add(
                new Peliculas("Iron Man", "Genio millonario se hace superheroe"));
            favoritas.Pelicula.Add(
                new Peliculas("Shrek", "Vida de un ogro en un pantano"));
            favoritas.Pelicula.Add(
                new Peliculas("Shrek", "Vida de un ogro en un pantano"));
            favoritas.Pelicula.Add(
                new Peliculas("Shrek", "Vida de un ogro en un pantano"));
            favoritas.Pelicula.Add(
                new Peliculas("Shrek", "Vida de un ogro en un pantano"));



            Playlists netflix = new Playlists("netflix");
            netflix.Titulo = "Peliculas de Netflix";
            netflix.Descripcion = "Playlist de peliculas de netflix que quiero ver";

            netflix.Pelicula.Add(
                new Peliculas("la bella y la besstia", "una mujer muy bella se enamora de una bestia"));
            netflix.Pelicula.Add(
                new Peliculas("aladdin", "ladron se enamora de una princesa"));
            netflix.Pelicula.Add(
                new Peliculas("aladdin", "ladron se enamora de una princesa"));
            netflix.Pelicula.Add(
                new Peliculas("aladdin", "ladron se enamora de una princesa"));
            netflix.Pelicula.Add(
                new Peliculas("aladdin", "ladron se enamora de una princesa"));
            netflix.Pelicula.Add(
                new Peliculas("aladdin", "ladron se enamora de una princesa"));
            netflix.Pelicula.Add(
                new Peliculas("aladdin", "ladron se enamora de una princesa"));






            playlists.Add(favoritas);
            playlists.Add(netflix);



            foreach (Playlists playlists in playlists)
            {
                Console.WriteLine("*" + playlists.Titulo + " de " + playlists.Descripcion);

                foreach (Peliculas pelicula in playlists.Peliculas)
                {
                    Console.WriteLine("*" + pelicula.Titulo + " de " + pelicula.Sinopsis);
                }

            }



       
            Console.Read();
        }
    }
}
