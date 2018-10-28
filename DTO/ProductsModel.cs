using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public  class ProductsModel
    {
        private string _productId;
        private string _productName;
        private string _productTypeId;
        private float _productPurchasePrice; // gia nhap
        private float _productWholePrice; // gia ban si
        private float _productRetailPrice; // gia ban le
        private string _productUnit;
        private string _productNotice;
        private int _productAmount;

        public string productId
        {
            get { return this._productId; }
            set { this._productId =value; }
        }

        public string productName
        {
            get { return this._productName ; }
            set { this._productName=value; }
        }

        public string productTypeId
        {
            get { return this._productTypeId; }
            set { this._productTypeId = value; }
        }

        public float productPurchasePrice
        {
            get { return this._productPurchasePrice; }
            set { this._productPurchasePrice = value; }
        }

        public float productWholePrice
        {
            get { return this._productWholePrice; }
            set { this._productWholePrice = value; }
        }

        public float productRetailPrice
        {
            get { return this._productRetailPrice; }
            set { this._productRetailPrice = value; }
        }

        public string productUnit
        {
            get { return this._productUnit; }
            set { this._productUnit = value; }
        }

        public string productNotice
        {
            get { return this._productNotice; }
            set { this._productNotice = value; }
        }

        public int productAmount
        {
            get { return this._productAmount; }
            set { this._productAmount = value; }
        }
    }
}
