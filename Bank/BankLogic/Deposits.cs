using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLogic
{
    public class ClientDeposit : Deposit
    {
        private ValueType _valuteType;
        private double _percent;
        private long _sum;
        private int _years;


        string Name {public get; private set; }
        public ValueType valuteType { get { return _valuteType; } }
        public double Percent { get { return _percent; } }
        public long Sum { get { return _sum; } }
        public int Years { get { return _years; } }

        public ClientDeposit(string name, ValueType vtype, double perc, long sum, int time)
        {
            Name = name;
            _valuteType = vtype;
            _percent = perc;
            _sum = sum;
            _years = time;
        }
    }
}
