using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pie2Shop.Models
{
    public class PieRepositorySqlServer : IPieRepository
    {
        private readonly AppDbContext appDbContext;

        public PieRepositorySqlServer(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public IEnumerable<Pie> AllPies => appDbContext.Pies.Include(p => p.Category);

        public IEnumerable<Pie> PiesOfTheWeek => appDbContext.Pies.
            Include(p => p.Category).
            Where(p => p.IsPieOfTheWeek == true);

        public Pie GetPieById(int pieId)
        {
            return appDbContext.Pies.Include(p => p.Category).SingleOrDefault(p => p.PieId == pieId);
        }

        public Pie GetPieByName(string name)
        {
            if (String.IsNullOrEmpty(name))
                return null;

            return appDbContext.Pies
                .Include(p => p.Category)
                .FirstOrDefault(p => p.Name.ToLower().Contains(name.ToLower()));
        }

        public IEnumerable<Pie> GetPiesByCategory(int CategoryId)
        {
            return appDbContext.Pies
                .Include(p => p.Category)
                .Where(p => p.CategoryId == CategoryId);
        }
    }
}
