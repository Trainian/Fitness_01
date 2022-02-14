using Fitness.Entityes;

namespace Fitness.Data
{
    public interface IDbContext
    {
        public Task<BlogEntity> GetBlogEntityById (int id);
    }
}