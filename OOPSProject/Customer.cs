using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSProject
{
    public enum Cities {Pune,Mumbai,Hyderabad,Banglore,Chenai,Delhi};
    internal class Customer
    {
        int _CustId;
        bool _Status;
        string _Name, _State;
        double _Balance;
        string _Country;
        Cities _City;
        public Customer(int CID)
        {
            _CustId = CID;
            _Status = false;
            _Name = "";
            _Balance = 5000.0;
            _State = "MH";
            _City = 0;
            _Country = "India";
        }
        //ReadOnly Property
        public int CustId
        {
            get { return _CustId; }
        }
        //Read-Write Property
        public bool Status
        {
            get { return _Status; }
            set { _Status = value; }
        }
        //Read-Write Property With Condition in Set
        public string Name
        {
            get { return _Name; }
            set 
            {
                if (_Status)
                {
                    _Name = value;
                }
            }
        }
        //Read-Write Property With Condition in get and Set
        public double Balance
        {
            get
            {
                if (_Status)
                {
                    return _Balance;
                }
                else
                {
                    return 0;
                }
            }
            set
            {
                if (_Status)
                {
                    if (value >= 500)
                    {
                        _Balance = value;
                    }                   
                }
            }
        }
        //Read-Write Property With enumerated properties
        public Cities city
        {
            get
            {
                return _City;
            }
            set
            {
                if (_Status)
                {
                    _City = value;
                }
            }
        }
        //Read-Write Property With different scope to each property accessor C#2.0
        public string state
        {
            get
            {
                return _State;
            }
            protected set
            {
                if (_Status)
                {
                    _State = value;
                }
            }            
        }
        //Read-Write Property With Automic or Auto-Implemented property accessor C#3.0
        public string Country
        {
            get;
            set;
        }="India";

        public string Continent
        {
            get;
        } = "Asia";
    }
}
