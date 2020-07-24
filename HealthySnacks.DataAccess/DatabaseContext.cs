﻿
using HealthySnacks.DataAccess.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.SQLite;
using System.IO;


namespace HealthySnacks.DataAccess
{
    public class DatabaseContext : DbContext
    {
        private const string DATABASE_PATH = "../HealthySnacks.DataAccess/SQLite/HealthySnacks.sqlite3";


        public DatabaseContext() :
                base(new SQLiteConnection()
                {
                    ConnectionString = new SQLiteConnectionStringBuilder()
                    {
                        DataSource = DATABASE_PATH,
                        ForeignKeys = true
                    }.ConnectionString
                }, true)


        {
            if (!File.Exists(DATABASE_PATH))

            {
                SQLiteConnection.CreateFile(DATABASE_PATH);
            }
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<HealthySnacks.DataAccess.Entities.HealthySnacks> HealthySnacks { get; set; }
    }
}
