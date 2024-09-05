using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    abstract class Travel
    {
        protected int travelnum;
        protected DateTime fromdate;
        protected int num_ofdays;
        protected string destination;
        protected double price;
        public Travel()
        { }

        public Travel(int travelnum, DateTime fromdate, int num_ofdays, string destination, double price)
        {
            this.travelnum = travelnum;
            this.fromdate = fromdate;
            this.num_ofdays = num_ofdays;
            this.destination = destination;
            this.price = price;
        }
        public int Travelnum
        {
            set { travelnum = value; }
            get { return travelnum; }
        }
        public int Num_ofdays
        {
            set { num_ofdays = value; }
            get { return num_ofdays; }
        }
        public DateTime Fromdata
        {
            set { fromdate = value; }
            get { return fromdate; }
        }
        public string Destination
        {
            set { destination = value; }
            get { return destination; }
        }
        public double Price
        {
            set { price = value; }
            get { return price; }
        }
        public abstract string Details();
        public abstract void ExtendDays(int days);
        public abstract void Discount(int d);


    }
}