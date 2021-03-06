using System;
using System.Collections.Generic;
using System.Text;
using $safeprojectname$.DAO;
using $safeprojectname$.DTO;

namespace $safeprojectname$.Logic
{
    class creaproducto
    {
        public List<dt_Product> CreateProduct()
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

            sen_Product dao_Product = new sen_Product();
            List<dt_Product> List_Products = dao_Product.CreateProduct(NameProduct, UnitPrice, UnitPerKilometer, 
                            TaxPerUnitPercentage);

            return List_Products;
        }
    }
}
