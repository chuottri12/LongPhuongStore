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
    public class BUS_ReceiveBill
    {
        DAL_ReceiveBill dalReceiveBill = new DAL_ReceiveBill();
        public DataTable Danhsach()
        {
            return dalReceiveBill.getAllData();
        }

        public DataTable Danhsach(string billId)
        {
            return dalReceiveBill.getDataWithBillId(billId);
        }

        public Boolean add(ReceiveBillModel receiveBill)
        {
            return dalReceiveBill.add(receiveBill);
        }

        public Boolean edit(ReceiveBillModel receiveBill)
        {
            return dalReceiveBill.edit(receiveBill);
        }
        
        public Boolean delete(ReceiveBillModel receiveBill)
        {
            return dalReceiveBill.delete(receiveBill);
        }
    }
}
