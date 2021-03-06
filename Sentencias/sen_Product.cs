using System;
using System.Collections.Generic;
using System.Text;
using $safeprojectname$.DTO;

namespace $safeprojectname$.DAO
{
    public class sen_Product
    {
        public List<dt_Product> CreateProduct(List<string> Name, List<int> UnitPrice, List<int> UnitPerKilometer,
                                   List<double> TaxPerUnitPercentage)
        {
            List<dt_Product> Product = new List<dt_Product>();

            for (int i = 0; i < Name.Count; i++)
            {
                Product.Add(new dt_Product() { Name = Name[i], UnitPrice = UnitPrice[i], UnitPerKilometer = UnitPerKilometer[i], 
                            TaxPerUnitPercentage = TaxPerUnitPercentage[i] });
            }

            return Product;
        }
    }
}
