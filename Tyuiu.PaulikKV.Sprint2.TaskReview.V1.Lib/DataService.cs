using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.PaulikKV.Sprint2.TaskReview.V1.Lib
{
    public class DataService : ISprint2Task7V1
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if ((y >= 0.5) && (y <= 1))
            {
                if ((x <= 0.5 && x >= -0.5) && (y >= 0.5 && y <= 1))
                {
                    res = true;
                }
                else
                {
                    res = false;
                }
            }
            else
            {
                if ((y <= 0.5 && y >= 0) && (x < 0.5 && x > -0.5))
                {
                    res = true;
                }
                else
                {
                    res = false;
                }
            }
            return res;
        }
    }
}
