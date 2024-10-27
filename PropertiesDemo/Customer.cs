using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesDemo
{
    public enum Cities
    {
        Pune, Mumbai, Delhi, Bangalor, Chennai
    }
    public enum Country
    {
        India, Rashia, Germany
    }
    internal class Customer
    {
        int _Custid;
        bool _Status;
        string _Name;
        string _State;
        double _Balance;
        Cities _Cities;
        Country _Country;
        public Customer(int Custid) 
        {
            _Custid = Custid;
            _Status = false;
            _Name = "Mahesh";
            _Balance = 330000;
            _Cities = 0;
            _State = "Maharashtra";
            _Country = 0;
        }
        public int Custid
        {
        get { return _Custid; } 
        }
        public bool Status
        {
            get { return (_Status); }
            set { _Status = value; }
        }
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
        public double Balance
        {
            get
            {
                if (_Status)
                {
                    return _Balance;
                }
                else return 0;
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
        public Cities city
        {
            get
            {
                return _Cities;
            }
        }
        public string State
        {
            get { return _State; }
            protected set
            {
                if (_Status)
                {
                    _State = value;
                }
            }
        }
        public string Country
        {
            get;
            private set;
        }
        public string Continent
        {
            get;
        } = "Asia";
    }
}
