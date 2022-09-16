using AutoMapper;
using System;

namespace FilmesApi.Data.Dtos.Sessoes
{
    public class CreateSessaoDTO 
    {

        public int CinemaId { get; set; }
        public int FilmeId { get; set; }
        public DateTime HorarioDeEncerramento { get; set; }

    }
}
