using PlatformService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlatformService.Data
{
    public interface IPlatformRepository
    {
        bool SaveChanges();
        IEnumerable<Platform> GetAll();
        Platform GetById(int id);
        void Create(Platform platform);
    }
}
