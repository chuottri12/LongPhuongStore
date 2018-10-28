using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;
namespace BUS
{
    public class BUS_ProductType
    {
        DAL_ProductType dalProductType = new DAL_ProductType();
        public DataTable getAllData()
        {
            return dalProductType.getAllData();
        }
        
        public Boolean add(ProductTypeModel productType)
        {
            return dalProductType.add(productType);
        }

        public Boolean edit(ProductTypeModel productType)
        {
            return dalProductType.edit(productType);
        }

        public Boolean delete(string productType)
        {
            return dalProductType.delete(productType);
        }

        public Dictionary<string, ProductTypeModel> convertDatatable2Dict()
        {
            return dalProductType.convertDatatable2Dict(getAllData());
        }
    }
}
