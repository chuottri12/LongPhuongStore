/**
 * Creator: TriCV
 * Date: 09/01/2018
 * Name: BillModel.cs
 * Description: define object and method for bill detail
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public  class BillModel
    {
    /*TriCV comment out 09/01/2018 begin*/
        /*
        private int _stt;
        public int Stt
        {
            get { return _stt; }
            set { _stt = value; }
        }
        */
    /*TriCV comment out 09/01/2018 end*/
        private string _billId;
        private string _productId;
        private string _date;
        private int _billAmount;
        private float _billPrice;
        private string _billUnit;
        private byte _billStatus;
        private string _billNotice;
        private string _employId;

        public string billId
        {
            get { return this._billId; }
            set { this._billId = value; }
        }
       
        public string productId
        {
            get { return this._productId; }
            set { this._productId = value; }
        }
       
        public string date
        {
            get { return this._date; }
            set { this._date = value; }
        }
        
        public int billAmount
        {
            get { return _billAmount; }
            set { _billAmount = value; }
        }
        
        public float billPrice
        {
            get { return _billPrice; }
            set { _billPrice = value; }
        }
        
        public string billUnit
        {
            get { return this._billUnit; }
            set { this._billUnit = value; }
        }
        
        public byte billStatus
        {
            get { return this._billStatus; }
            set { this._billStatus = value; }
        }
        
        public string billNotice
        {
            get { return this._billNotice; }
            set { this._billNotice = value; }
        }

        public string employId
        {
            get { return this._employId; }
            set { this._employId = value; }
        }
    }
}
