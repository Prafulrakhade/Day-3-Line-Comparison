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
        public void UC_2_checkEqual()
        {
            Console.WriteLine("check line 1 and line 2 First value ");
            Data();                                   // we can call method inside the method also
            if (x1 == x2)                              //if line 1 x1 value and line 2 x2 value check equals or not by using Equals method
            {
                Console.WriteLine(Equals(y1, (y2))); //Equals methods gives 'true' or 'false' only
            }
            else
            {
                line1 = x1 - x2;                    // Equals method check the line 1 value  and line 2 value is equal or not
                line2 = y1 - y2;
                Console.WriteLine(Equals(line1, (line2)));   //Equals methods gives 'true' or 'false' only
            }
        }
        public void UC_3_Compare()
        {
            Console.WriteLine("Check line 1 And line 2 Equal or Not");
            Data();

            if (x1 == x2)
            {

                int comp = (y1.CompareTo(y2)); //Compare method compare the line 1 y1 value and line 2 y2 value
                if (comp == 0)
                {
                    Console.WriteLine("Line 1 and Line 2 are Euqal");
                }
                else if (comp >= 0)
                {
                    Console.WriteLine("Line 1 is Greater than line 2");
                }
                else
                {
                    Console.WriteLine("Line 1 is Smaller than line 2");
                }
            }
            else
            {
                line1 = y1 - x1;
                line2 = y2 - x2;

                int comp = (line1.CompareTo(line2));  // Compare method compare the line 1 value  and line 2 value
                if (comp == 0)
                {
                    Console.WriteLine("Both Line 1 and Line 2 are Equal");
                }
                else if (comp >= 0)
                {
                    Console.WriteLine("Line 2 is Smaller than line 1");
                }
                else
                {
                    Console.WriteLine("Line 2 is Greater than line 1");
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("---------------- WELCOME TO LINE COMPARISON COMPUTATION PROGRAM ----------------------");
            Console.WriteLine();

            Program program = new Program();
            program.uc_1_CalculationOfLenght();
            program.UC_2_checkEqual();
            program.UC_3_Compare();
        }
    }
}
