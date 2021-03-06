using System;
using System.Collections.Generic;
using $safeprojectname$.Logic;
using $safeprojectname$.DTO;

namespace $safeprojectname$
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateFarmers createFarmers = new CreateFarmers();
            List<Dto_Farmer> Farmers = createFarmers.CreateFarmer();

            CreateProducts createProducts = new CreateProducts();
            List<Dto_Product> Products = createProducts.CreateProduct();

            CreateCropsFarmers createCropsFarmers = new CreateCropsFarmers();
            List<Dto_Crop> Crops = createCropsFarmers.CreateCropFarmer(Products, Farmers);

            BusinessLogicTheFarmersCompany.PaymentValueToCapitalists(Crops, Farmers);
            BusinessLogicTheFarmersCompany.PaymentValueToFarmers(Crops);
            BusinessLogicTheFarmersCompany.LowestPriceSell(Crops);
        }
    }
}
