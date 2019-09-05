using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPrimerParcial
{
    class Peliculas
    {
        public string Titulo{ get; set; }
        public string Genero { get; set; }
        public string PaisOrigen { get; set; }
        public string Sinopsis { get; set; }

        private int _añoestreno;

        public int AñoEstreno 
        {
            get
            {
                return _añoestreno;
            }
            set
            {
                if (value <= 1800)
                {
                    throw new Exception("fecha debe ser entre 1800 y 2019");
                }
                if (value >= 2019)
                {
                    throw new Exception("fecha debe ser entre 1800 y 2019");
                }

                else
                {
                    _añoestreno = value;
                    
                }

            }
        }

        public int _duracion;
        public int Duracion
        {
            get
            {
                return _duracion;
            }
            set
            {
                if (value > 0)
                {
                    _duracion = value;
                }
                
                else
                {
                    throw new Exception("la duracion debe ser mayor a 0");
                }

            }
        }

        
        public double _rating;
        public double Rating
        {
            get
            {
                return _rating;
            }
            set
            {
                if (value <=10)
                {
                    _rating = value;
                }

                else
                {
                    throw new Exception("rating maxima es 10");
                }

            }
        }

        public Peliculas()
        {
            Titulo = "Sin titulo";
            AñoEstreno = 2000;
            Genero ="Sin Genero";
            PaisOrigen ="Sin Pais";
            Duracion = 5;
            Rating = 0;
            Sinopsis = "Sin sinopsis";

        }


        public Peliculas(string titulo, int añoestreno, string genero, string paisorigen, int duracion,double rating,string sinopsis)
        {
            Titulo = titulo;
            AñoEstreno = añoestreno;
            Genero = genero;
            PaisOrigen = paisorigen;
            Duracion = duracion;
            Rating = rating;
            Sinopsis = sinopsis;

        }

        public Peliculas(string titulo,string sinopsis)
        {
            Titulo = titulo;
            Sinopsis = sinopsis;
        }
    }
}
