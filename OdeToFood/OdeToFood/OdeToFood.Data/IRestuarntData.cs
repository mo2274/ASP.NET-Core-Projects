using OdeToFood.Core;
using System.Collections.Generic;
using System.Text;

namespace OdeToFood.Data
{
    public interface IRestuarntData
    {
        IEnumerable<Resturant> GetAll();
        IEnumerable<Resturant> GetResturantsByName(string name = null);
        Resturant Edit(Resturant resturant);
        Resturant Create(Resturant resturant);
        int Commit();
        Resturant Delete(int id);
        Resturant GetResturantsById(int id);
        int GetCountOfResturants();
    }
}
