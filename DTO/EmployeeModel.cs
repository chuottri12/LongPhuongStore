/**
 * Creator: TriCV
 * Date: 09/01/2018
 * Name: EmployeeModel
 * Description: define object and properties for Employee table
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public  class EmployeeModel
    {
       /* 09/01/2018 TriCV define new properties for Employee model add Begin*/
        private string _emPloyId;
        private string _emPloyName;
        private string _emPloyAccount;
        private string _quarterId;
        private DateTime _emPloyDOB;
        private bool _emPloySex;
        private string _emPloyNumberPhone;
        private float _emPloySalary;
        private string _emPloyPassword;
        private byte[] _emPloyImage;
        private string _emPloyAddress;
       /* 09/01/2018 TriCV define new properties for Employee model add END*/

        /* 09/01/2018 TriCV getter/setter for properties add Begin*/
        public string emPloyId
        {
            get { return _emPloyId; }
            set { _emPloyId = value; }
        }

        public string emPloyName
        {
            get { return _emPloyName; }
            set { _emPloyName = value; }
        }

        public string emPloyAccount
        {
            get { return this._emPloyAccount; }
            set { this._emPloyAccount = value; }
        }

        public string quarterId
        {
            get { return _quarterId; }
            set { _quarterId = value; }
        }

        public DateTime emPloyDOB
        {
            get { return _emPloyDOB; }
            set { _emPloyDOB = value; }
        }

        public bool emPloySex
        {
            get { return _emPloySex; }
            set { _emPloySex = value; }
        }

        public string emPloyNumberPhone
        {
            get { return _emPloyNumberPhone; }
            set { _emPloyNumberPhone = value; }
        }

        public string emPloyAddress
        {
            get { return _emPloyAddress; }
            set { _emPloyAddress = value; }
        }

        public float emPloySalary
        {
            get { return _emPloySalary; }
            set { _emPloySalary = value; }
        }

        public string emPloyPassword
        {
            get { return _emPloyPassword; }
            set { _emPloyPassword = value; }
        }

        public byte[] emPloyImage
        {
            get { return _emPloyImage; }
            set { _emPloyImage = value; }
        }
       /* 09/01/2018 TriCV getter/setter for properties add Begin*/

        /**
         * @name    EmployeeModel
         * 
         * @brief   Constructor
         * 
         * @param   string
         *          string
         *          string
         *          string
         *          DateTime
         *          string
         *          string
         *          float
         *          string
         *          byte[]
         *          string
         * 
         * @return  Object
         * 
         * @author  TriCV
         * 
         * @date    09/01/2018
         */
        public EmployeeModel(string _emPloyId,
                            string _emPloyName,
                            string _emPloyAccount,
                            string _quarterId,
                            DateTime _emPloyDOB,
                            bool _emPloySex,
                            string _emPloyNumberPhone,
                            float _emPloySalary,
                            string _emPloyPassword,
                            byte[] _emPloyImage,
                            string _emPloyAddress)
        {
            this._emPloyId = _emPloyId;
            this._emPloyName = _emPloyName;
            this._quarterId = _quarterId;
            this._emPloyDOB = _emPloyDOB;
            this._emPloySex = _emPloySex;
            this._emPloyNumberPhone = _emPloyNumberPhone;
            this._emPloyAddress = _emPloyAddress;
            this._emPloySalary = _emPloySalary;
            this._emPloyPassword = _emPloyPassword;
            this._emPloyImage = _emPloyImage;
            this._emPloyAccount = _emPloyAccount;
        }

        /**
        * @name    EmployeeModel
        * 
        * @brief   default Constructor
        * 
        * @param   none
        * 
        * @return  Object
        * 
        * @author  TriCV
        * 
        * @date    09/01/2018
        */
        public EmployeeModel() {  }
    }
}
