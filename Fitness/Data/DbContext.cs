using Fitness.Data;
using Fitness.Entityes;
using Microsoft.EntityFrameworkCore;

namespace Fitness.Data
{
    public class DbContext : IDbContext
    {
        private ApplicationDbContext _db;
        
        public DbContext(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<BlogEntity> GetBlogEntityById (int id)
        {
            return await _db.BlogEntities.FirstOrDefaultAsync(b => b.Id == id);
        }
    }
}