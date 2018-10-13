using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SellBillModel:BillModel
    {
        private string _customerId;
        public string customerId
        {
            get { return _customerId; }
            set { _customerId = value; }
        }
    }
}
