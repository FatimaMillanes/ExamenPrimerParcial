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

        public List<Peliculas> playlistpelicula{ get; set; }

        public Playlists()
        {
            Titulo = "Sin titulo";
            Descripcion = "Sin descripcion";
            playlistpelicula = new List<Peliculas>();

     
        }

        public Playlists(string titulo, string descripcion)
        {
            Titulo = titulo;
            Descripcion = descripcion;
            playlistpelicula = new List<Peliculas>();
        }


    }
}
