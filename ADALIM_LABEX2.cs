using System;

namespace ComputeAverageApp
{
    class ComputeAverageProgram
    {
        static void Main(string[] args)
        {
            //Greetings
            Console.WriteLine("WELCOME STIERS!");
            Console.WriteLine("");
            
            // array
            double[] grades = new double[5];
            
            // ask for input of 5 grades
            Console.WriteLine("Please enter five grades(from grade 1-5): ");

            for (int x = 0; x < grades.Length; x++)
            {
                Console.Write($"\nGrade level {x + 1}: ");
                
            //convert to double to find the average
                grades[x] = Convert.ToDouble(Console.ReadLine());
            }

            // computation of average
            double averageNum = 0;
            for (int x = 0; x < grades.Length; x++)
            {
                averageNum += grades[x];
            }
            averageNum /= grades.Length;

            // Rounding using Math.Round(average)
            double roundAverage = Math.Round(averageNum);

            // Display the rounded average
            Console.WriteLine($"\nThe total average of the grades (unrounded) is: {averageNum}");
            Console.WriteLine($"\nThe total rounded average of the grades is: {roundAverage} ");
            
            //last code 
            Console.WriteLine("\n\nPress any key to exit...");
            
            
        
        }
    }
}
