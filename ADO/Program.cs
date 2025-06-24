using System;

namespace CRUD
{
    class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    internal class AppDbContext : DbContext
    {
        public DbSet<Item> Items { get; set; }
        
        
    }   
}