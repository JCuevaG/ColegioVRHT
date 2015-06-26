namespace ColegioVRHT.Entities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class COLEGIO : DbContext
    {
        public COLEGIO()
            : base("name=COLEGIO")
        {
        }

        public virtual DbSet<Alumno> Alumno { get; set; }
        public virtual DbSet<AlumnoAula> AlumnoAula { get; set; }
        public virtual DbSet<HorarioCurso> HorarioCurso { get; set; }
        public virtual DbSet<Profesor> Profesor { get; set; }
        public virtual DbSet<Aula> Aula { get; set; }
        public virtual DbSet<Cargo> Cargo { get; set; }
        public virtual DbSet<Ciclo> Ciclo { get; set; }
        public virtual DbSet<Curso> Curso { get; set; }
        public virtual DbSet<CursoProfesor> CursoProfesor { get; set; }
        public virtual DbSet<Especialidad> Especialidad { get; set; }
        public virtual DbSet<Grupo> Grupo { get; set; }
        public virtual DbSet<Laboratorio> Laboratorio { get; set; }
        public virtual DbSet<LaboratorioDetalle> LaboratorioDetalle { get; set; }
        public virtual DbSet<Parametro> Parametro { get; set; }
        public virtual DbSet<Sexo> Sexo { get; set; }
        public virtual DbSet<TipoUsuario> TipoUsuario { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<Nota> Nota { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alumno>()
                .Property(e => e.Nombres)
                .IsUnicode(false);

            modelBuilder.Entity<Alumno>()
                .Property(e => e.Apellidos)
                .IsUnicode(false);

            modelBuilder.Entity<Alumno>()
                .Property(e => e.NombreApoderado)
                .IsUnicode(false);

            modelBuilder.Entity<Alumno>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<Alumno>()
                .Property(e => e.DNI)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Alumno>()
                .Property(e => e.CorreoPersonal)
                .IsUnicode(false);

            modelBuilder.Entity<Alumno>()
                .Property(e => e.CorreoCorporativo)
                .IsUnicode(false);

            modelBuilder.Entity<Alumno>()
                .Property(e => e.Telefono)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Alumno>()
                .Property(e => e.Celular)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Alumno>()
                .HasMany(e => e.AlumnoAula)
                .WithRequired(e => e.Alumno)
                .HasForeignKey(e => e.IdAlumno)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Alumno>()
                .HasMany(e => e.Nota)
                .WithRequired(e => e.Alumno)
                .HasForeignKey(e => e.IdAlumno)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HorarioCurso>()
                .Property(e => e.HoraInicio)
                .IsUnicode(false);

            modelBuilder.Entity<HorarioCurso>()
                .Property(e => e.HoraFin)
                .IsUnicode(false);

            modelBuilder.Entity<Profesor>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<Profesor>()
                .Property(e => e.Nombres)
                .IsUnicode(false);

            modelBuilder.Entity<Profesor>()
                .Property(e => e.Apellidos)
                .IsUnicode(false);

            modelBuilder.Entity<Profesor>()
                .Property(e => e.DNI)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Profesor>()
                .Property(e => e.CorreoPersonal)
                .IsUnicode(false);

            modelBuilder.Entity<Profesor>()
                .Property(e => e.CorreoCorporativo)
                .IsUnicode(false);

            modelBuilder.Entity<Profesor>()
                .Property(e => e.InstitucionEgresado)
                .IsUnicode(false);

            modelBuilder.Entity<Profesor>()
                .Property(e => e.Telefono)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Profesor>()
                .Property(e => e.Celular)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Aula>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Aula>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<Aula>()
                .HasMany(e => e.AlumnoAula)
                .WithRequired(e => e.Aula)
                .HasForeignKey(e => e.IdAula)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Aula>()
                .HasMany(e => e.HorarioCurso)
                .WithRequired(e => e.Aula)
                .HasForeignKey(e => e.IdAula)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Aula>()
                .HasMany(e => e.Laboratorio)
                .WithRequired(e => e.Aula)
                .HasForeignKey(e => e.IdAula)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cargo>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Cargo>()
                .HasMany(e => e.Profesor)
                .WithRequired(e => e.Cargo)
                .HasForeignKey(e => e.IdCargo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Ciclo>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Ciclo>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<Ciclo>()
                .HasMany(e => e.Aula)
                .WithRequired(e => e.Ciclo)
                .HasForeignKey(e => e.IdCiclo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Ciclo>()
                .HasMany(e => e.Curso)
                .WithRequired(e => e.Ciclo)
                .HasForeignKey(e => e.IdCiclo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Curso>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Curso>()
                .Property(e => e.DescripcionCorta)
                .IsUnicode(false);

            modelBuilder.Entity<Curso>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<Curso>()
                .HasMany(e => e.HorarioCurso)
                .WithRequired(e => e.Curso)
                .HasForeignKey(e => e.IdCurso)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Curso>()
                .HasMany(e => e.CursoProfesor)
                .WithRequired(e => e.Curso)
                .HasForeignKey(e => e.IdCurso)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Curso>()
                .HasMany(e => e.Nota)
                .WithRequired(e => e.Curso)
                .HasForeignKey(e => e.IdCurso)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Especialidad>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<Especialidad>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Especialidad>()
                .HasMany(e => e.Profesor)
                .WithRequired(e => e.Especialidad)
                .HasForeignKey(e => e.IdEspecialidad)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Grupo>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Grupo>()
                .HasMany(e => e.Parametro)
                .WithRequired(e => e.Grupo)
                .HasForeignKey(e => e.IdGrupo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Laboratorio>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Laboratorio>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<Laboratorio>()
                .HasMany(e => e.LaboratorioDetalle)
                .WithRequired(e => e.Laboratorio)
                .HasForeignKey(e => e.IdLaboratorio)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sexo>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Sexo>()
                .Property(e => e.DescripcionCorta)
                .IsUnicode(false);

            modelBuilder.Entity<Sexo>()
                .HasMany(e => e.Alumno)
                .WithRequired(e => e.Sexo)
                .HasForeignKey(e => e.IdSexo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sexo>()
                .HasMany(e => e.Profesor)
                .WithRequired(e => e.Sexo)
                .HasForeignKey(e => e.IdSexo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TipoUsuario>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TipoUsuario>()
                .HasMany(e => e.Usuario)
                .WithRequired(e => e.TipoUsuario)
                .HasForeignKey(e => e.IdTipoUsuario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Usuario1)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Password)
                .IsUnicode(false);
        }
    }
}
