using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
     public  class ReceiveBillModel:BillModel
    {
        private string _contributorId;
        public string contributorId
        {
            get { return _contributorId; }
            set { _contributorId = value; }
        }
     }
}
