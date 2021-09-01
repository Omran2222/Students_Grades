using System;

namespace Students_Grades_1
{
    class Program
    {
        static void Main(string[] args)
        {

            string strYN; 
            do
            {
                Console.WriteLine("Enter Student Name");
                Console.ReadLine();
                Console.WriteLine("Enter Student Degree");
                double Degree = double.Parse(Console.ReadLine());

                if (Degree >= 60)
                {
                    Console.WriteLine("Passed");
                }
                else
                {
                    Console.WriteLine("Failed");

                }
                Console.WriteLine("=======================================================");
                Console.WriteLine("DO you want to add another student Y/N: ");
                strYN = Console.ReadLine();
            }
            while (strYN == "y" || strYN == "Y");
            


        }           

        
    }
}
