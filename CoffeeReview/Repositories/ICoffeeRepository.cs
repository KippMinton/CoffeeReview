using CoffeeShop.Models;
using System.Collections.Generic;

namespace CoffeeShop.Repositories
{
    public interface ICoffeeRepository
    {
        List<Coffee> GetAll();
        Coffee Get(int id);
        void Add(Coffee coffee);
        void Update(Coffee coffee);
        void Delete(int id);
    }
}