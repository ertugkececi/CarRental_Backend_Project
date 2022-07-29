// See https://aka.ms/new-console-template for more information
using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

CarTest();

static void CarTest()
{
    CarManager CarManager = new CarManager(new EfCarDal());

    foreach (var carDetails in CarManager.GetCarDetails())
    {
        Console.WriteLine($"{carDetails.CarName} - {carDetails.BrandName} - {carDetails.ColorName} - {carDetails.DailyPrice}");
    }
}

