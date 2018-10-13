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
    public class BUS_Customer
    {
        DAL_Customer dalCustomer = new DAL_Customer();

        public DataTable getAllData()
        {
            return dalCustomer.getAllCustomer();
        }

        public DataTable getDataWithId(string customerId )
        {
            return dalCustomer.getCustomerWithId(customerId);
        }

        public Boolean add(CustomerModel customer)
        {
            return dalCustomer.add(customer);
        }

        public Boolean edit(CustomerModel customer)
        {
            return dalCustomer.update(customer);
        }

        public Boolean delete(string customerId)
        {
            return dalCustomer.delete(customerId);
        }

        public Boolean delete(List<CustomerModel> customerList)
        {
            return dalCustomer.delete(customerList);
        }

        public string SinhMakh()
        {
            return dalCustomer.SinhMakh();
        }

    }
}
