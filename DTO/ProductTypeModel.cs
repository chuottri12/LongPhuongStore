/**
 * Creator: TriCV
 * Date: 09/01/2018
 * Name: ProductType.cs
 * Description: define object and method for product type
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public  class ProductTypeModel
    {
      /* 09/01/2018 TriCV define new properties for Product type model add Begin*/
       private string _productTypeId;
       private string _productTypeName;
       private string _productNotice;
      /* 09/01/2018 TriCV define new properties for Product type model add Begin*/

      /* 09/01/2018 TriCV getter/setter for properties add Begin*/
       public string productTypeId
        {
            get { return this._productTypeId; }
            set { this._productTypeId = value; }
        }

        public string productTypeName
        {
            get { return this._productTypeName; }
            set { this._productTypeName = value; }
        }
        
        public string productNotice
        {
            get { return this._productNotice ; }
            set { this._productNotice  = value; }
        }
       /* 09/01/2018 TriCV getter/setter for properties add Begin*/

        /**
          * @name    ProductType
          * 
          * @brief   Constructor
          * 
          * @param   string
          *          string
          *          string
          * 
          * @return  Object
          * 
          * @author  TriCV
          * 
          * @date    09/01/2018
          */
        public ProductTypeModel(string _productTypeId, string _productTypeName, string _productNotice)
        {
            this._productTypeId = _productTypeId;
            this._productTypeName = _productTypeName;
            this._productNotice = _productNotice;
        }

        /**
           * @name    ProductType
           * 
           * @brief   Constructor
           * 
           * @param   none
           * 
           * @return  Object
           * 
           * @author  TriCV
           * 
           * @date    09/01/2018
           */
        public ProductTypeModel() {  }
    }
}
