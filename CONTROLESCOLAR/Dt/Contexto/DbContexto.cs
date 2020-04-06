using DataLayer.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Contexto
{
	//El pakete
	// https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.Sqlite/3.1.2?_src=template
	public class DbContexto : DbContext
	{
		// qui creas un daset un data set es solo un acceso rapido es opcional si se quiere usar
		public DbSet<Clave> Usuarios { get; set; }
		public DbSet<Alumnos> Alumnos { get; set; }

		public DbSet<Docente> Docentes { get; set; }
		public DbSet<AULAS> Aulas { get; set; }

		public DbSet<NOTAS> NOTAS { get; set; }

		public DbSet<Matricula> MATRICULA { get; set; }

		public DbSet<CALIFICACIONES> CALIFICACIONEs { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlite("Data Source=CONTROLESCOLAR.db");
		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			//region se usa para marcar blokes de codigo para que sea mas facil de separar
			//aqui tienes que mappear tus entidades esto es un poco complicado de entender pero como tu base de datos es simple

			// solo mapealas asi
			#region Docente
			modelBuilder.Entity<Docente>().HasKey(x => x.ID);
			modelBuilder.Entity<Docente>().HasIndex(x => x.CEDULA).IsUnique();

			modelBuilder.Entity<Docente>().ToTable("DOCENTE");
			#endregion
			#region Clave
			modelBuilder.Entity<Clave>().HasKey(x => x.ID);
			modelBuilder.Entity<Clave>().ToTable("CLAVE");
			#endregion

			#region Alumnos 
			modelBuilder.Entity<Alumnos>().HasKey(x => x.ID);
			modelBuilder.Entity<Alumnos>().HasIndex(x => x.MATRICULA).IsUnique();
			modelBuilder.Entity<Alumnos>().ToTable("ALUMNOS");
			#endregion

			modelBuilder.Entity<AULAS>().HasKey(x => x.ID);
			modelBuilder.Entity<AULAS>().ToTable("AULAS");

			#region NOTAS
			modelBuilder.Entity<NOTAS>().HasKey(x => x.ID);
			modelBuilder.Entity<NOTAS>().HasIndex(x => x.TRIMESTRE).IsUnique();

			modelBuilder.Entity<NOTAS>().ToTable("NOTAS");
            #endregion

            #region MATRICULA
            modelBuilder.Entity<Matricula>().HasKey(x => x.ID);
			modelBuilder.Entity<Matricula>().HasIndex(x => x.MATRICULA).IsUnique();// sabes para que se usa esa linea

			modelBuilder.Entity<Matricula>().ToTable("MATRICULA");

			#region
			modelBuilder.Entity<CALIFICACIONES>().HasKey(x => x.ID);
			modelBuilder.Entity<CALIFICACIONES>().HasIndex(x => x.MATERIA).IsUnique();// sabes para que se usa esa linea
			
			modelBuilder.Entity<CALIFICACIONES>().ToTable("CALIFICACIONES");
			#endregion
			#endregion

		}
    }
}



