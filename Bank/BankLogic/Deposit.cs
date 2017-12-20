using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLogic
{
    public enum ValuteType
    {
        rub,
        dol,
        eur
    }

    public interface Deposit
    {
        string Name { get; set; }
        ValueType valuteType { get; }
        double Percent { get; }
        long Sum { get; }
        int Years { get; }
    }
}
