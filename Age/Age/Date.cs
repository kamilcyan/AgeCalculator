using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age
{
    public class Date
    {
        public DateTime BirthDate { get; set; }
        public DateTime CurrentDate { get; set; }
        public double numberOfSeconds { get; set; }

        public Date(DateTime birt, DateTime now)
        {
            this.BirthDate = birt;
            this.CurrentDate = now;
        }

        public double DateCounter()
        {
            numberOfSeconds = (CurrentDate - BirthDate).TotalSeconds;
            return numberOfSeconds;
        }
    }
}
