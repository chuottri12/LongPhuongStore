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
    public class BUS_SellBill
    {
        DAL_SellBill dalSellBill = new DAL_SellBill();
        public DataTable getAllData()
        {
            return dalSellBill.getAllData();
        }

        public DataTable getDataWithId(string sellBillId)
        {
            return dalSellBill.getDataWithBillId(sellBillId);
        }

        public Boolean add(SellBillModel sellBillModel)
        {
            return dalSellBill.add(sellBillModel);
        }

        public Boolean edit(SellBillModel sellBillModel)
        {
            return dalSellBill.edit(sellBillModel);
        }

        public Boolean delete(string billId)
        {
            return dalSellBill.delete(billId);
        }

        public Boolean delete(List<SellBillModel> sellBillList)
        {
            return dalSellBill.delete(sellBillList);
        }       
    }
}
