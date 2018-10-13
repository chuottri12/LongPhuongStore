/**
 * Creator: TriCV
 * Date: 09/01/2018
 * Name: QuarterModel
 * Description: define object and properties for Quarter
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class QuarterModel
    {   
        /* 09/01/2018 TriCV define new properties for Quarter model add Begin*/
        private string _quarterId;
        private string _quarterName;
        private string _quarterAgency;
        /* 09/01/2018 TriCV define new properties for Quarter model add End*/

        /* 09/01/2018 TriCV getter/setter for properties add Begin*/
        public string quarterId
        {
            get { return this._quarterId; }
            set { this._quarterId = value; }
        }
        
        public string quarterName
        {
            get { return this._quarterName; }
            set { this._quarterName = value; }
        }
        
        public string quarterAgency
        {
            get { return this._quarterAgency; }
            set { this._quarterAgency = value; }
        }
        /* 09/01/2018 TriCV getter/setter for properties add End*/

        /**
         * @name    QuarterModel
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
        public QuarterModel(string _quarterId, string _quarterName, string _quarterAgency)
        {
            this._quarterId = _quarterId;
            this._quarterName = _quarterName;
            this._quarterAgency = _quarterAgency;
        }
        
        /**
         * @name    QuarterModel
         * 
         * @brief   Constructor
         * 
         * @param   string
         *          string
         * 
         * @return  Object
         * 
         * @author  TriCV
         * 
         * @date    09/01/2018
         */
        public QuarterModel(string _quarterId, string _quarterName)
        {
            this._quarterId = _quarterId;
            this._quarterName = _quarterName;
        }

        /**
         * @name    QuarterModel
         * 
         * @brief   default Constructor
         * 
         * @param   none
         * 
         * @return  object
         * 
         * @author  TriCV
         * 
         * @date    09/01/2018
         */
        public QuarterModel() { }
    }
}
