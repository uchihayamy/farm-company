using System;
using System.Collections.Generic;
using System.Text;
using $safeprojectname$.DAO;
using $safeprojectname$.DTO;

namespace $safeprojectname$.Logic
{
    class CreateProducts
    {
        public List<Dto_Product> CreateProduct()
        {
            List<string> NameProduct = new List<string>()
            {
                "carrot", "broccoli", "asparagus", "corn", "lettuce", "potato", "tomato"
            };

            List<int> UnitPrice = new List<int>()
            {
                100, 75, 80, 130, 65, 180, 210
            };

            List<int> UnitPerKilometer = new List<int>()
            {
                200, 400, 30, 500, 150, 200, 370
            };

            List<double> TaxPerUnitPercentage = new List<double>()
            {
                10, 20, 30, 10, 12, 16, 34
            };

            Dao_Product dao_Product = new Dao_Product();
            List<Dto_Product> List_Products = dao_Product.CreateProduct(NameProduct, UnitPrice, UnitPerKilometer, 
                            TaxPerUnitPercentage);

            return List_Products;
        }
    }
}
