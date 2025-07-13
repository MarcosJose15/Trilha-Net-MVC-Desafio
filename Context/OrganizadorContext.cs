using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trilha_Net_MVC_Desafio.Models;
using Microsoft.EntityFrameworkCore;


namespace Trilha_Net_MVC_Desafio.Context
{
    public class OrganizadorContext : DbContext
    {
        public OrganizadorContext(DbContextOptions<OrganizadorContext> options) : base(options)
        {
            
        }

        public DbSet<Tarefa> Tarefas { get; set; }
    }
}