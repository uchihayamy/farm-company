using System;
using System.Collections.Generic;
using System.Text;
using $safeprojectname$.DAO;
using $safeprojectname$.DTO;

namespace $safeprojectname$.Logic
{
    public class crearfarmer
    {
        public List<dt_Farmer> CreateFarmer()
        {
            List<string> Name = new List<string>()
            {
                "Dylan arias", "Brayan moncada", "Sthef blanq", "Gina tangarife", "Leo Vargas"
            };

            List<int> Document = new List<int>()
            {
                1111, 2222, 3333, 4444, 5555
            };

            List<string> Gender = new List<string>()
            {
                "M", "M", "F", "F", "M"
            };

            List<int> Stratum = new List<int>()
            {
                4, 5, 3, 2, 4
            };

            List<string> Capitalist = new List<string>()
            {
                "False", "False", "False", "False", "True"
            };

            sen_Farmer Obj_Dao_Farmer = new sen_Farmer();
            List<dt_Farmer> List_Farmers = Obj_Dao_Farmer.CreateFarmer(Name, Document, Gender, Stratum, Capitalist);

            return List_Farmers;
        }
    }
}
