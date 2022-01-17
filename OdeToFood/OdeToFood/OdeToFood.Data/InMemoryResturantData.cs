using OdeToFood.Core;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.Data
{
    public class InMemoryResturantData : IRestuarntData
    {
        List<Resturant> Resturants;
        public InMemoryResturantData()
        {
            Resturants = new List<Resturant>()
            {
                new Resturant() {Id = 1, Name = "Scott's Pizza", Location = "Maryland",
                    Coisine = CoisineType.Italian},
                new Resturant() {Id = 2, Name = "Cinnamon Club", Location = "London",
                    Coisine = CoisineType.Indian},
                new Resturant() {Id = 3, Name = "La Costa", Location = "Mexico", 
                    Coisine = CoisineType.Mexican}
            };
        }

        public int Commit()
        {
            return 0;
        }

        public Resturant Create(Resturant resturant)
        {
            resturant.Id = Resturants.Max(r => r.Id) + 1;
            Resturants.Add(resturant);
            return resturant;
        }

        public Resturant Delete(int id)
        {
            var resturant = Resturants.SingleOrDefault(r => r.Id == id);
            if (resturant != null)
                Resturants.Remove(resturant);

            return resturant;
        }

        public Resturant Edit(Resturant resturant)
        {
            var oldResturant = Resturants.SingleOrDefault(r => r.Id == resturant.Id);
            if (oldResturant is null)
                return null;
            oldResturant.Name = resturant.Name;
            oldResturant.Location = resturant.Location;
            oldResturant.Coisine = resturant.Coisine;

            return oldResturant;
        }

        public IEnumerable<Resturant> GetAll()
        {
            return Resturants.OrderBy(R => R.Name);
        }

        public int GetCountOfResturants()
        {
            throw new NotImplementedException();
        }

        public Resturant GetResturantsById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Resturant> GetResturantsByName(string name = null)
        {
            return Resturants.Where(R => 
                       name is null || R.Name.ToLower().Contains(name.ToLower())
                    );
        }
    }
}
