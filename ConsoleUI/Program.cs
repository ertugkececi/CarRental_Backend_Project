// See https://aka.ms/new-console-template for more information
using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

CarTest();

static void CarTest()
{
    CarManager carManager = new CarManager(new EfCarDal());

    var carResult = carManager.GetCarDetails();

    foreach (var carDetails in carResult.Data)
    {
        Console.WriteLine($"{carDetails.CarName} - {carDetails.BrandName} - {carDetails.ColorName} - {carDetails.DailyPrice}");
    }
}

