using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1=new Car { Id = 1, ModelYear = 2018, DailyPrice = 400, 
                Description = "A5 Cabrio", BrandId = 1, ColorId = 1002 };
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());

            //-----------------------ColorManager CRUD Testleri--------------------------------
            //colorManager.Delete(new Color { Id = 2002, ColorName = "Orange" });
            //colorManager.Update(new Color { Id=2,ColorName="Orange"});
            //colorManager.Add(new Color { ColorName="Lila"});
            //ColorGetByIdTest(colorManager);
            //ColorGetAllTest(colorManager);
            

            //-----------------------BrandManager CRUD Testleri--------------------------------
            //brandManager.Update(new Brand {Id=1005,BrandName="Opel" });
            //brandManager.Delete(new Brand { Id = 1004 });
            //brandManager.Add(new Brand { BrandName = "Volkswagen" });
            //BrandGetByIdTest(brandManager);
            // BrandGetAll(brandManager);

            //-----------------------CarManager CRUD Testleri--------------------------------
            //carManager.Update(car1);
            //carManager.Delete(car1);
            //carManager.Add(car1);
            //ColorIdFilterTest(carManager);
            //BrandIdFilterTest(carManager);
            //ModelYearFilterTest(carManager);
            //CarDetailTest(carManager);
            //CarGetAllTest(carManager);
        }

        private static void ColorGetByIdTest(ColorManager colorManager)
        {
            var result = colorManager.GetById(4);
            if (result.Success == true)
            {
                foreach (var r in result.Data)
                {
                    Console.WriteLine(r.ColorName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void ColorGetAllTest(ColorManager colorManager)
        {
            var result = colorManager.GetAll();
            if (result.Success == true)
            {
                foreach (var r in result.Data)
                {
                    Console.WriteLine(r.ColorName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void BrandGetByIdTest(BrandManager brandManager)
        {
            var result = brandManager.GetById(1);
            if (result.Success == true)
            {
                foreach (var b in result.Data)
                {
                    Console.WriteLine(b.BrandName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void BrandGetAll(BrandManager brandManager)
        {
            var result = brandManager.GetAll();
            if (result.Success == true)
            {
                foreach (var b in result.Data)
                {
                    Console.WriteLine(b.BrandName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }            
        }

        private static void ColorIdFilterTest(CarManager carManager)
        {
            var result = carManager.GetCarsByColorId(3);
            if (result.Success==true)
            {
                foreach (var c in result.Data)
                {
                    Console.WriteLine(c.Description);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
           
        }

        private static void BrandIdFilterTest(CarManager carManager)
        {
            var result = carManager.GetCarsByBrandId(2);
            if (result.Success==true)
            {
                foreach (var c in result.Data )
                {
                    Console.WriteLine(c.Description);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
           
        }

        private static void ModelYearFilterTest(CarManager carManager)
        {
            var result = carManager.GetByModelYear(2010, 2016);
            if (result.Success == true)
            {
                foreach (var c in result.Data)
                {
                    Console.WriteLine(c.ModelYear);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void CarDetailTest(CarManager carManager)
        {
            var result = carManager.GetCarDetail();
            if (result.Success == true)
            {
                foreach (var c in result.Data)
                {
                    Console.WriteLine(c.BrandName + " " + c.Description
                    + " " + c.ModelYear + " " + c.ColorName
                    + " " + c.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void CarGetAllTest(CarManager carManager)
        {
            var result = carManager.GetAll();
            if (result.Success == true)
            {
                foreach (var c in result.Data)
                {
                    Console.WriteLine(c.Description);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }           
        }
    }
}
