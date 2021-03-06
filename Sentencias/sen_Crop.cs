using System;
using System.Collections.Generic;
using System.Text;
using $safeprojectname$.DTO;

namespace $safeprojectname$.DAO
{
    public class sen_Crop
    {
        public List<dt_Crop> CreateCropFarmer(List<dt_Product> Product, List<int> Extension, List<dt_Farmer> Farmer, List<string> Status)
        {
            List<dt_Crop> Crop = new List<dt_Crop>();
            int n = 0;
            int i = 0;
            int Existencias = 0;

            while (i < Product.Count)
            {
                if (n < Farmer.Count)
                {
                    for (int j = 0; j < Crop.Count; j++)
                    {
                        if (Crop[j].Farmer.Document == Farmer[n].Document)
                        {
                            Existencias++;
                        }
                    }

                    if (Existencias > 0)
                    {
                        if (Farmer[n].Capitalist == "True")
                        {
                            Crop.Add(new dt_Crop()
                            {
                                Product = Product[i],
                                Extension = Extension[i],
                                Farmer = Farmer[n],
                                Status = Status[i]
                            });
                            i++;
                        }
                    } else {
                        Crop.Add(new dt_Crop()
                        {
                            Product = Product[i],
                            Extension = Extension[i],
                            Farmer = Farmer[n],
                            Status = Status[i]
                        });
                        i++;
                    }

                    n++;
                } else {
                    n = 0;
                    for (int j = 0; j < Crop.Count; j++)
                    {
                        if (Crop[j].Farmer.Document == Farmer[n].Document)
                        {
                            Existencias++;
                        }
                    }

                    if (Existencias > 0)
                    {
                        if (Farmer[n].Capitalist == "True")
                        {
                            Crop.Add(new dt_Crop()
                            {
                                Product = Product[i],
                                Extension = Extension[i],
                                Farmer = Farmer[i],
                                Status = Status[i]
                            });
                            i++;
                        }
                    }
                    else
                    {
                        Crop.Add(new dt_Crop()
                        {
                            Product = Product[i],
                            Extension = Extension[i],
                            Farmer = Farmer[n],
                            Status = Status[i]
                        });
                        i++;
                    }

                    n++;
                }
            }
            return Crop;
        }
    }
}