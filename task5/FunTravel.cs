using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    class FunTravel : OutTravel
    {
        protected bool isvisa;
        public FunTravel()
        { }
        public FunTravel(int travelnum, DateTime fromdate, int num_ofdays, string destination, double price, string airline, bool isvisa)
            : base(travelnum, fromdate, num_ofdays, destination, price, airline)
        {
            this.isvisa = isvisa;

        }
        public bool IsVisa
        {
            set { isvisa = value; }
            get { return isvisa; }
        }

        public override string Details()
        {
            return "Travel Number : " + travelnum + "  From Date : " + fromdate + "  Number Of Days : " + num_ofdays + "  Destination :  " + destination + "  Price = " + price + "  Transportation  " + airline + " IsVisa " + isvisa;
        }
        public override void ExtendDays(int days)
        {
            num_ofdays += days;
        }
        public override void Discount(int d)
        {
            Price -= (Price * d / 100);
        }
    }
}