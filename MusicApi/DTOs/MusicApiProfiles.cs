﻿using AutoMapper;
using MusicApi.Models;

namespace MusicApi.DTOs
{
    public class MusicApiProfiles : Profile
    {
        public MusicApiProfiles()
        {
            CreateMap<Song, SongReadDto>();
        }
        
    }
}