using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPrimerParcial
{
    class Playlists
    {
        public string Titulo { get; set; }
        public string Descripcion { get; set; }

        public List<Peliculas> Pelicula{ get; set; }

        public Playlists()
        {
            Titulo = "Peliculas favoritas";
            Descripcion = "Playlist de mis peliculas favoritas";
            Pelicula = new List<Peliculas>();

     
        }

        public Playlists(string titulo)
        {
            Titulo = titulo;
            Descripcion = "Sin descripcion";
            Pelicula = new List<Peliculas>();
        }


    }
}
