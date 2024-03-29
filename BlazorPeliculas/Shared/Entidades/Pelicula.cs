﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorPeliculas.Shared.Entidades
{
    public class Pelicula
    {
        public int Id { get; set; }
        [Required]
        public string Titulo { get; set; } = null!;
        public string? Resumen { get; set; }
        public bool EnCartelera { get; set; }
        public string Trailer { get; set; }
        public DateTime? Lanzamiento { get; set; }
        public string? Poster { get; set; }
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
