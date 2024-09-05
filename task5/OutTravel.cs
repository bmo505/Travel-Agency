using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    class OutTravel : Travel
    {
        protected string airline;
        public OutTravel()
        { }
        public OutTravel(int travelnum, DateTime fromdate, int num_ofdays, string destination, double price, string airline)
            : base(travelnum, fromdate, num_ofdays, destination, price)
        {
            this.airline = airline;
        }
        public string Airline
        {
            set { airline = value; }
            get { return airline; }
        }
        public override string Details()
        {
            return "Travel Number : " + travelnum + "  From Date : " + fromdate + "  Number Of Days : " + num_ofdays + "  Destination :  " + destination + "  Price = " + price + "  Transportation  " + airline;
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