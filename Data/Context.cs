using System.Collections.Generic;

using Data.Model;
using Microsoft.EntityFrameworkCore;

/// <summary>
/// Пространство с имена наречено Data.
/// </summary>
namespace Data
{
    /// <summary>
    /// Клас Context, наследяващ DbContext.
    /// </summary>
    public class Context : DbContext
    {
        /// <summary>
        /// Свързваща връзка. 
        /// </summary> 
        private const string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=shkoloButBetter;Integrated Security=True;";

        /// <summary>
        /// Задава колекция Marks.
        /// </summary>
        public DbSet<Information> Informations { get; set; }

        /// <summary>
        /// Задава колекция Students.
        /// </summary>
        public DbSet<Person> People { get; set; }

        /// <summary>
        /// Конструктор Context
        /// </summary>
        public Context()
        {
            // Създава автоматично базата данни.
            Database.EnsureCreated();
        }

        /// <summary>
        /// Свързваща връзка с Microsoft SQL Server.
        /// </summary> 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

    }
}