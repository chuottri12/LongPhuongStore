using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using DTO;

namespace BUS
{
   public  class BUS_Quarter
    {
        DAL_Quarter dalQuarter = new DAL_Quarter();

        public DataTable getAllData()
        {
            return dalQuarter.getAllData();
        }

        public Boolean add(QuarterModel quarterModel)
        {
            return dalQuarter.add(quarterModel);
        }

        public Boolean edit(QuarterModel quarterModel)
        {
            return dalQuarter.edit(quarterModel);
        }

        public Boolean delete(QuarterModel quarterModel)
        {
            return dalQuarter.delete(quarterModel);
        }

        public Dictionary<string, QuarterModel> convertQuarterDatatable2Dict()
        {
            return dalQuarter.convertDatatable2Dict(getAllData());
        }
    }
}
