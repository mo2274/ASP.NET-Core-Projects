using Microsoft.EntityFrameworkCore;
using OdeToFood.Core;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.Data
{
    public class SqlResturantData : IRestuarntData
    {
        private readonly OdeToFoodDbContext dbContext;

        public SqlResturantData(OdeToFoodDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public int Commit()
        {
            return dbContext.SaveChanges();
        }

        public Resturant Create(Resturant resturant)
        {
            if (resturant != null)
                dbContext.Resturants.Add(resturant);
            return resturant;
        }

        public Resturant Delete(int id)
        {
            var resturant = dbContext.Resturants.Find(id);
            if (resturant != null)
                dbContext.Resturants.Remove(resturant);
            return resturant;
        }

        public Resturant Edit(Resturant resturant)
        {
            var entity = dbContext.Resturants.Attach(resturant);
            entity.State = EntityState.Modified;
            return resturant;
        }

        public IEnumerable<Resturant> GetAll()
        {
            return dbContext.Resturants;
        }

        public int GetCountOfResturants()
        {
            return dbContext.Resturants.Count();
        }

        public Resturant GetResturantsById(int id)
        {
            return dbContext.Resturants.Find(id);
        }

        public IEnumerable<Resturant> GetResturantsByName(string name = null)
        {
            return dbContext.Resturants.Where(r => name == null || r.Name.Contains(name));
        }
    }
}
