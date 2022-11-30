using oop_lab5_rpv_task_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace oop_lab_5_rpv_task_2
{
    class OrdinaryCalc : AbstractCalc
    {
        public double num1;
        public double num2;

        public static void OrdinaryCalculator()
        {
            bool is_work = true;
            while (is_work)
            {
                Console.WriteLine("");
                Console.WriteLine(" |--------------------------------| ");
                Console.WriteLine(" |      Choise the operation:     | ");
                Console.WriteLine(" |--------------------------------| ");
                Console.WriteLine(" |   1. Addition                  | ");
                Console.WriteLine(" |   2. Subtraction               | ");
                Console.WriteLine(" |   3. Multiplication            | ");
                Console.WriteLine(" |   4. Division                  | ");
                Console.WriteLine(" |   5. Exit                      | ");
                Console.WriteLine(" |--------------------------------| ");
                Console.WriteLine("");
                int choise = int.Parse(Console.ReadLine());
                if (choise == 5)
                {
                    is_work = false;
                    break;
                }
                Console.WriteLine("Please, write the numbers:");
                Console.WriteLine("Number 1:");
                var first_number = new OrdinaryCalc();
                SetNum1(first_number);
                Console.WriteLine("Number 2:");
                var second_number = new OrdinaryCalc();
                SetNum2(second_number);
                Console.WriteLine();
                if (choise == 1)
                {
                    var add_numbers = new OrdinaryCalc();
                    double result = add_numbers.Add(GetNum1(first_number), GetNum2(second_number));
                    Console.WriteLine(result);
                }
                if (choise == 2)
                {
                    var sub_numbers = new OrdinaryCalc();
                    double result = sub_numbers.Sub(GetNum1(first_number), GetNum2(second_number));
                    Console.WriteLine(result);
                }
                if (choise == 3)
                {
                    var mult_numbers = new OrdinaryCalc();
                    double result = mult_numbers.Mul(GetNum1(first_number), GetNum2(second_number));
                    Console.WriteLine(result);
                }
                if (choise == 4)
                {
                    var div_numbers = new OrdinaryCalc();
                    if ((GetNum2(second_number) == 0))
                    {
                        Console.WriteLine("division by zero is not allowed!");
                    }
                    else
                    {
                        double result = div_numbers.Div(GetNum1(first_number), GetNum2(second_number));
                        Console.WriteLine(result);
                    }
                }

            }

        }
        public static void SetNum1(OrdinaryCalc numb1)
        {
            double num = double.Parse(Console.ReadLine());
            numb1.num1 = num;
        }

        public static double GetNum1(OrdinaryCalc numb1)
        {
            return numb1.num1;
        }
        public static void SetNum2(OrdinaryCalc numb2)
        {
            double num = double.Parse(Console.ReadLine());
            numb2.num2 = num;
        }
        public static double GetNum2(OrdinaryCalc numb2)
        {
            return numb2.num2;
        }

        public override double Add(double number_1, double number_2)
        { return number_1 + number_2; }

        public override double Div(double number_1, double number_2)
        { return number_1 / number_2; }

        public override double Mul(double number_1, double number_2)
        { return number_1 * number_2; }
        public override double Sub(double number_1, double number_2)
        { return number_1 - number_2; }
    }
}
