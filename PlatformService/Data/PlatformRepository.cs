using PlatformService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlatformService.Data
{
    public class PlatformRepository : IPlatformRepository
    {
        private readonly AppDbContext dbContext;

        public PlatformRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Create(Platform platform)
        {
            if (platform == null)
                throw new ArgumentNullException(nameof(platform));

            dbContext.Platforms.Add(platform);
        }

        public IEnumerable<Platform> GetAll()
        {
            return dbContext.Platforms.ToList();
        }

        public Platform GetById(int id)
        {
            return dbContext.Platforms.FirstOrDefault(p => p.Id == id);
        }

        public bool SaveChanges()
        {
            return (dbContext.SaveChanges() > 0);
        }
    }
}
