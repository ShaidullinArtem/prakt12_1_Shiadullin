using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_11_12
{
    public class Student
    {
        public string name;
        public double rost;
        public double ves;
        public double eda;

        public void SetEat(double eda)
        {

            if (eda > 5 && eda < 10)
            {
                rost -= 1;
                ves += (eda * 1000 - 1600) / 1000;
            }
            else if (eda > 10)
            {
                rost -= 2;
                ves += (eda * 1000 - 1800) / 1000;
            }
            else
            {
                ves += (eda * 1000 - 1600) / 1000;
            }

        }

        public double GetEat()
        {
            return ves;
        }
    }
}
