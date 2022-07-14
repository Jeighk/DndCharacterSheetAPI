using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Npgsql.EntityFrameworkCore.PostgreSQL;
using DndCharacterSheetAPI.Models;

namespace DndCharacterSheetAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseSerialColumns();
        }
        public DbSet<CharacterModel> Characters { get; set; }
        public DbSet<ItemModel> Items { get; set; }
        public DbSet<LanguageModel> Languages { get; set; }
        public DbSet<ProficiencyModel> Proficiencies { get; set; }
        public DbSet<FlawModel> Flaws { get; set; }
    }
}
