using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyVet4.Web.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyVet4.Web.Data
{
    public class DataContext : IdentityDbContext<User>
    {
        //el DbContextOptions es una base de datos basada en el DataContext
        //llamada options y asu vez se lo pasamos al constructor de la superclase
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        //cuales entities vamos a mapear en la base de datos
        //es decir la base de datos contendra al modelo owner
        public DbSet<Agenda> Agendas { get; set; }
        public DbSet<History> Histories { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<PetType> PetTypes { get; set; }
        public DbSet<ServiceType> ServiceTypes { get; set; }



    }
}
