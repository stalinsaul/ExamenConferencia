using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Curso_de_C.DataAccess.Models;

namespace Curso_de_C.DataAccess.Conexion
{
    public class AppDbcontext:DbContext
    {
        public AppDbcontext(): base(@"Data Source=DESKTOP-40AVOMB\SQLEXPRESS;Initial Catalog=Universidad; user id=saul; Password=123; MultipleActiveResultSets=true") 
        {
            try
            {
                // Verifica si la base de datos se puede conectar
                if (this.Database.Exists())
                {
                    Console.WriteLine("Conexión exitosa a la base de datos.");
                    Database.SetInitializer(new MigrateDatabaseToLatestVersion<AppDbcontext, Configuration>());
                    this.Database.Initialize(false);
                }
                else
                {
                    Console.WriteLine("No se pudo encontrar la base de datos.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error de conexión: " + ex.Message);
            }
        }

        public DbSet<Conferencia> Conferencia { get; set; }
    }

    public class Configuration : DbMigrationsConfiguration<AppDbcontext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true; // Habilitar migraciones automáticas
            AutomaticMigrationDataLossAllowed = true; // Permitir pérdida de datos (¡Ten cuidado en producción!)
        }

        protected override void Seed(AppDbcontext context)
        {
            Console.WriteLine("Migraciones aplicadas y base de datos inicializada.");
        }
    }
}
