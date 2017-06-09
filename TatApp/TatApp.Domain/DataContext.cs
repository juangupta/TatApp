using System.Data.Entity;

namespace TatApp.Domain
{
    public class DataContext: DbContext
    {
        public DataContext() : base("DefaultConnection")
        {
        }

        public System.Data.Entity.DbSet<TatApp.Domain.DocumentType> DocumentTypes { get; set; }
    }
}
