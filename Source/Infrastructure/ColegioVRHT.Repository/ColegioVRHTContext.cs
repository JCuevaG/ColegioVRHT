using ColegioVRHT.Entities;
using System;
using System.Data.Entity;


namespace ColegioVRHT.Repository
{
    public class ColegioVRHTContext :DbContext
    {

        public ColegioVRHTContext() 
            :base("Cnx_ColegioVRHT")
        {

        }

        public DbSet<Alumno> Alumnos { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alumno>();   
        }
    }
}
