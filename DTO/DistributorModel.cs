using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DistributorModel
    {
        private string _distributorId;
        private string _distributorName;
        private string _distributorNumberPhone;
        private string _distributorManager;
        private string _distributorEmail;
        private string _distributorAddress;
        private string _distributorNotice;

        public string distributorId
        {
            get { return this._distributorId; }
            set { this._distributorId = value; }
        }

        public string distributorName
        {
            get { return this._distributorName; }
            set { this._distributorName = value; }
        }

        public string distributorNumberPhone
        {
            get { return this._distributorNumberPhone; }
            set { this._distributorNumberPhone = value; }
        }

        public string distributorManager
        {
            get { return this._distributorManager; }
            set { this._distributorManager = value; }
        }

        public string distributorEmail
        {
            get { return this._distributorEmail; }
            set { this._distributorEmail = value; }
        }

        public string distributorAddress
        {
            get { return this._distributorAddress; }
            set { this._distributorAddress = value; }
        }

        public string distributorNotice
        {
            get { return this._distributorNotice; }
            set { this._distributorNotice = value; }
        }
    }
}
