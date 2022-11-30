using oop_lab_5_rpv_task_2;
using oop_lab5_rpv_task_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lab_5_rpv_task_2
{
    class AdvancedClass : OrdinaryCalc, IAdvanced
    {
        public double num1;
        public double num2;

        public static void AdvaCalc()
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
                Console.WriteLine(" |   5. Root                      | ");
                Console.WriteLine(" |   6. Exit                      | ");
                Console.WriteLine(" |--------------------------------| ");
                Console.WriteLine("");
                int choise = int.Parse(Console.ReadLine());
                if (choise == 6)
                {
                    is_work = false;
                    break;
                }
                if (choise == 1 || choise == 2 || choise == 3 || choise == 4)
                {
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
                else if (choise == 5)
                {
                    Console.WriteLine("Enter the number: ");

                    var root_num = new AdvancedClass();
                    SetNum1(root_num);
                    if (GetNum1(root_num) <= 0 || GetNum1(root_num) > 10000)
                    {
                        Console.WriteLine("Wrong range!");

                    }
                    else
                    {
                        double result = root_num.Root(GetNum1(root_num));
                        Console.WriteLine(result);
                    }


                }


            }
        }
        public double Root(double number)
        {
            return Math.Sqrt(number);
        }
    }

}

