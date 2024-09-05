using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    class InTravel : Travel
    {

        string transportation;
        public InTravel()
        { }
        public InTravel(int travelnum, DateTime fromdate, int num_ofdays, string destination, double price, string transportation)
            : base(travelnum, fromdate, num_ofdays, destination, price)
        {
            this.transportation = transportation;
        }
        public string Transportation
        {
            set { transportation = value; }
            get { return transportation; }
        }
        public string Cho_trans()
        {
            if (transportation == "Flight")
                return transportation = "Flight";
            else if (transportation == "Bus")
                return transportation = "Bus";
            else
                return transportation = "Invalid";

        }
        public override string Details()
        {
            return "Travel Number : " + travelnum + "  From Date : " + fromdate + "  Number Of Days : " + num_ofdays + "  Destination :  " + destination + "  Price = " + price + "  Transportation  " + transportation;
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