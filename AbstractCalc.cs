using oop_lab_5_rpv_task_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lab5_rpv_task_2
{
    abstract class AbstractCalc
    {
        public abstract double Add(double number_1, double number_2);
        public abstract double Div(double number_1, double number_2);
        public abstract double Mul(double number_1, double number_2);
        public abstract double Sub(double number_1, double number_2);
    }
}
