using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaProject
{
    public class Customer
    {
        private string custphone;
        private string custname;
        private string custaddr1;
        private string custaddr2;
        private string custcity;
        private string custstate;
        private string custzip;

        public string CustPhone
        {
            get
            {
                return custphone;
            }
            set
            {
                custphone = value;
            }
        }
        public string CustName
        {
            get
            {
                return custname;
            }
            set
            {
                custname = value;
            }
        }
        public string CustAddr1
        {
            get
            {
                return custaddr1;
            }
            set
            {
                custaddr1 = value;
            }
        }
        public string CustAddr2
        {
            get
            {
                return custaddr2;
            }
            set
            {
                custaddr2 = value;
            }
        }
        public string CustCity
        {
            get
            {
                return custcity;
            }
            set
            {
                custcity = value;
            }
        }
        public string CustState
        {
            get
            {
                return custstate;
            }
            set
            {
                custstate = value;
            }
        }
        public string CustZip
        {
            get
            {
                return custzip;
            }
            set
            {
                custzip = value;
            }
        }
    }
}
