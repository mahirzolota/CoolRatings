using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoolRatings.Models
{
    public class DBContext : DbContext
    {

        public DBContext(DbContextOptions<DBContext> options): base(options)
        {

        }


        public DbSet<ShowModel> showModels { get; set; }

        public DbSet<RatingsModel> ratingsModels { get; set; }

        public DbSet<TypeModel> typeModels { get; set; }

        public DbSet<CastModel> castModels { get; set; }

        public DbSet<UserModel> userModels { get; set; }
    }
}
