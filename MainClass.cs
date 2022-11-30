using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lab_5_rpv_task_2
{
    public class MainClass
    {
        public static void Menu()
        {
            Console.WriteLine("");
            Console.WriteLine(" |--------------------------------| ");
            Console.WriteLine(" |   Enter the choise of menu:    | ");
            Console.WriteLine(" |--------------------------------| ");
            Console.WriteLine(" |   1. Ordinary calc             | ");
            Console.WriteLine(" |   2. Advanced calc             | ");
            Console.WriteLine(" |   3. Exit                      | ");
            Console.WriteLine(" |--------------------------------| ");
            Console.WriteLine("");
            int choise = int.Parse(Console.ReadLine());
            switch (choise)
            {
                case 1:
                    OrdinaryCalc.OrdinaryCalculator();
                    Menu();
                    break;
                case 2:
                    AdvancedClass.AdvaCalc();
                    Menu();
                    break;
                case 3:
                    break;
                default:
                    Console.WriteLine("Wrong choise,try again.");
                    Menu();
                    break;
            }


        }
        public static void Main(string[] args) => Menu();
    }
}