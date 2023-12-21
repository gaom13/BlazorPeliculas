﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorPeliculas.Shared.Entidades
{
    public class Pelicula
    {
        public string? Titulo { get; set; }
        public DateTime FechaLanzamiento { get; set; }
        public string Poster { get; set; } = null! ;
        public string TituloCortado { 
            get{
                if(string.IsNullOrWhiteSpace(Titulo)){
                    return "";
                }
                return Titulo.Length > 60 ? $"{Titulo.Substring(0, 60)}..." : Titulo;
            }    
        }
    }
}
