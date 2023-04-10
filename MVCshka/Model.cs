using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCshka 
{
    internal class Model
    {
        public Model(double firstValue, double secondValue, double thirdValue)
        {
            this.firstValue = firstValue;
            this.secondValue = secondValue;
            this.thirdValue = thirdValue;
        }

        public double firstValue { get; set; }

        public double secondValue { get; set; }
        public double thirdValue { get; set; }
        public double result { get; set; }



    }
}
