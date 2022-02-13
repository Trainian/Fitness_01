using Fitness.Entityes;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Fitness.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public DbSet<BlogEntity> BlogEntities {get;set;}
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
        //Database.EnsureDeleted();
        Database.EnsureCreated();
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<BlogTitle>().HasData(
            new BlogTitle(){
                Id = 1, 
                IdBlog = 1, 
                Title = "Use Your Reset Button To Change Your Vibration",
                Text = "You may feel like you will never possess enough commitment power to quit smoking cigarettes. However, trying to stop smoking is just like all things else in the world. It takes practice. Very few individuals stop for good on the principal try. Each time you try to stop, it will get a little easier, especially if you are knowledgeable of some of the best ways to quit smoking.These days, there are a variety of goods on the market that can assist you to stop smoking cigarettes. There are laser smoking restraint treatments, acupuncture cessation smoking methods, and even a smoking cessation shot. You can also see your physician to obtain a stop smoking antidepressant."
            },
            new BlogTitle(){
                Id = 2,
                IdBlog = 1,
                Title = "Use Your Reset Button To Change Your Vibration",
                Text = "Whether you enjoy city breaks or extended holidays in the sun, you can always improve your travel experiences by staying in a small, charming hotel, where the atmosphere is welcoming and friendly and the service is fabulous. There are hundreds of hotels that are self-styled “boutique” places to stay, but not all of them fall into the traditional definition of boutique, which includes."
            }
        );
    }
}
