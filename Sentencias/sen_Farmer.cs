using System;
using System.Collections.Generic;
using System.Text;
using $safeprojectname$.DTO;

namespace $safeprojectname$.DAO
{
    public class sen_Farmer
    {
        public List<dt_Farmer> CreateFarmer(List<string> Name, List<int> Document, 
                                        List<string> Gender, List<int> Stratum, List<string> Capitalist)
        {
            List<dt_Farmer> Farmer = new List<dt_Farmer>();

            for (int i = 0; i < Name.Count; i++)
            {
                Farmer.Add(new dt_Farmer() { Name = Name[i], Document = Document[i], Gender = Gender[i], 
                            Stratum = Stratum[i], Capitalist = Capitalist[i] });
            }

            return Farmer;
        }
    }
}