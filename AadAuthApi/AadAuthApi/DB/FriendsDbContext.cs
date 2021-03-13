using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AadAuthApi.DB
{
    public class FriendsDbContext : DbContext
    {
        public DbSet<Friendship> Friendships { get; set; }

        public FriendsDbContext(DbContextOptions<FriendsDbContext> options)
            : base(options)
        { }
    }
}
