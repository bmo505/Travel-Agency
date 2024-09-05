using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    class RelTravel : OutTravel
    {
        string path;
        public RelTravel()
        { }
        public RelTravel(int travelnum, DateTime fromdate, int num_ofdays, string destination, double price, string airline, string path)
            : base(travelnum, fromdate, num_ofdays, destination, price, airline)
        {
            this.path = path;

        }
        public string Path
        {
            set { path = value; }
            get { return path; }
        }
        public string Chopath()
        {
            if (path == "Madina To Makka")
                return path = "Madina To Makka";
            else if (path == "Makka To Madina")
                return path = "Makka To Madina";
            else
                return path = "invalid";
        }

    }
}