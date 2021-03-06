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
            crearfarmer createFarmers = new crearfarmer();
            List<dt_Farmer> Farmers = createFarmers.CreateFarmer();

            creaproducto createProducts = new creaproducto();
            List<dt_Product> Products = createProducts.CreateProduct();

            crearcultivofarmer createCropsFarmers = new crearcultivofarmer();
            List<dt_Crop> Crops = createCropsFarmers.CreateCropFarmer(Products, Farmers);

            principalcodefarmer.PaymentValueToCapitalists(Crops, Farmers);
            principalcodefarmer.PaymentValueToFarmers(Crops);
            principalcodefarmer.LowestPriceSell(Crops);
        }
    }
}
