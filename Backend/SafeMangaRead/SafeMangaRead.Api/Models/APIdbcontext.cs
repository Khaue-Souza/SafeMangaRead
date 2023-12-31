﻿using MangasAPI.Models;
using NovelsAPI.Models;
using Microsoft.EntityFrameworkCore;
using UsuarioAPI.Models;
using ListaDeLeituraApi.Models;

namespace MangaNovelsAPI.Models
{
    public class APIdbcontext : DbContext
    {
        public APIdbcontext(DbContextOptions option) : base(option)
        {

        }

        public DbSet<Mangas> mangas { get; set; }
        public DbSet<Novels> novels { get; set; }
        public DbSet<Usuario> usuarios { get; set; }
        public DbSet<ListaDeLeitura> listasDeLeitura { get; set; }
    }
}
