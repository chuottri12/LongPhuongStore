using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
     public  class CustomerModel
     {
         private string _customerId;
         private string _customerName;
         private DateTime _customerDOB;
         private string _customerNumberPhone;
         private string _customerEmail;
         private string _customerAddress;
         private float _customerAmountOfDebt;
         private string _customerSex;
         private byte _customerType;
         private byte[] _customerImage;

         public string customerId
         {
             get { return this._customerId; }
             set { this._customerId = value; }
         }

         public string customerName
         {
             get { return this._customerName; }
             set { this._customerName = value; }
         }
         
         public DateTime customerDOB
         {
             get { return this._customerDOB; }
             set { this._customerDOB = value; }

         }
         
         public string customerSex
         {
             get { return this._customerSex; }
             set { this._customerSex = value; }

         }

         public string customerNumberPhone
         {
             get { return this._customerNumberPhone; }
             set { this._customerNumberPhone = value; }
         }

         public string customerEmail
         {
             get { return this._customerEmail; }
             set { this._customerEmail = value; }
         }

         public string customerAddress
         {
             get { return this._customerAddress; }
             set { this._customerAddress = value; }
         }

         public float customerAmountOfDebt
         {
             get { return this._customerAmountOfDebt; }
             set { this._customerAmountOfDebt = value; }
         }

         public byte customerType
         {
             get { return this._customerType; }
             set { this._customerType = value; }
         }

         public byte[] customerImage
         {
             get { return this._customerImage; }
             set { this._customerImage = value; }
         }
     }
}
