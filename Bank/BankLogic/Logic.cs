using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BankLogic
{
    public static class Logic
    {
        public static readonly List<Deposit> Deposits= new List<Deposit>();

        public static void Initialize()
        {
            InitDeposits();
        }

        private static void InitDeposits()
        {
            using (StreamReader sr = new StreamReader()) { }
        }

    }
}
