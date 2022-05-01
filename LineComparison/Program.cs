using System;

namespace LineComparison
{
    internal class Program
    {
        double x1, y1, x2, y2;
        double line1, line2;
        double distance = 0;
        public void Data()  // for following the dry principle I have create a repeatation code in one mathod and apply or use that method 
        {

            Console.WriteLine("Enter the line-1 Coordinates (x1 , y1) ");
            x1 = double.Parse(Console.ReadLine());
            y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the line-2 Coordinates (x2 , y2) ");
            x2 = double.Parse(Console.ReadLine());
            y2 = double.Parse(Console.ReadLine());
        }

        public void uc_1_CalculationOfLenght()
        {
            Data();    //its call method calling and follow the DRY principle  //class method       
            Console.WriteLine("Enter the line-1 Co-ordinates (x1 , y1) ");
            distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * ((y2 - y1)));          //Math.sqrt is a inbuild c#
            Console.WriteLine("The Distance of line 1 and line 2 = " + distance);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("---------------- WELCOME TO LINE COMPARISON COMPUTATION PROGRAM ----------------------");
            Console.WriteLine();

            Program program = new Program();
            program.uc_1_CalculationOfLenght();
        }
    }
}
