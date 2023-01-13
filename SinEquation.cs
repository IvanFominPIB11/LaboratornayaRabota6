    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratornayaRabota6
{
    public class SinEquation : Equation 
    {
     public readonly double a;
  
        public SinEquation(double a)
        {
            this.a = a;
        }

        public override double GetValue(double x)
        {
            //if (x == 0)
            //    return 0;
            return 50*Math.Sin(a * x) / x;
        }
        public override string ToString()
        {
            return "Синусоида";
        }

    }
}
