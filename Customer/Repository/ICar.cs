using Customer.Models;
using System.Collections.Generic;

namespace Customer.Repository

{
    public interface ICar

    {
        List<Models.Car> getAllCar();
        List<Car> getAllCarByCategoryId(int categoryId);
    }
}
