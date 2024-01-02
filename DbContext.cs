namespace KarigarBotique.Data
{
    public class DbContext
    {
        private DbContextOptions<DataContext> options;

        public DbContext(DbContextOptions<DataContext> options)
        {
            this.options = options;
        }

        internal void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            throw new NotImplementedException();
        }
    }
}