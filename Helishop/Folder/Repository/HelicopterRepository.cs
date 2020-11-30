using Helishop.Folder.Interfaces;
using Helishop.Folder.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Helishop.Folder.Repository
{
    public class HelicopterRepository : IAllHelicopters
    {
        private readonly AppDBContent appDBContent;

        public HelicopterRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Helicopter> Helicopters => appDBContent.Helicopter.Include(c => c.Category);

        public Helicopter getObjectHelicopter(int helicopterID) => appDBContent.Helicopter.FirstOrDefault(p => p.id == helicopterID);
    }
}
