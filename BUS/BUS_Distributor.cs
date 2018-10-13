using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class BUS_Distributor
    {
        DAL_Distributor dalDistributor = new DAL_Distributor();

        public DataTable getAllData()
        {
            return dalDistributor.getAllData();
        }

        public DataTable getDataWithId(string distributorId)
        {
            return dalDistributor.getDataWithId(distributorId);
        }

        public Boolean add(DistributorModel distributorModel)
        {
            return dalDistributor.add(distributorModel);
        }

        public Boolean edit(DistributorModel distributorModel)
        {
            return dalDistributor.edit(distributorModel);
        }

        public Boolean delete(string distributorId)
        {
            return dalDistributor.delete(distributorId);
        }
    }
}
