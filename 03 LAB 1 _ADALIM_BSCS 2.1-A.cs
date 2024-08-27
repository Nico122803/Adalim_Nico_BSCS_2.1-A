using System;

namespace StudentGradeApplication
{
    class frmStudentGradeProgram
    {
        static void Main(string[] args)
        {
            //Greeting 
             Console.Write("WELCOME STIERS!!!"); 
             Console.Write("\nDREAM HIGH, FLY HIGH");
             
            // ask user for name
            Console.Write("\n\n ENTER YOU NAME (FULLNAME!): ");
            string sName = Console.ReadLine();
            
            // array of 5 subjects
            string[] subjects = { "English", "Math", "Science", "Filipino", "History" };
            double[] grades = new double[subjects.Length];
            double total = 0;

            // grade of each subject
            for (int i = 0; i < subjects.Length; i++)
            {
                Console.Write($"Enter grade for {subjects[i]}: ");
                while (!double.TryParse(Console.ReadLine(), out grades[i]) || grades[i] < 0 || grades[i] > 100)
                {
                    Console.Write("Invalid input. Please enter a grade between 0 and 100: ");
                }
                total += grades[i];
            }

            // average 
            double averageG = total / subjects.Length;
            string result = averageG >= 75.00 ? "passed" : "failed";

            // Display the results
            Console.WriteLine($"\nStudent Name: {sName}");
            Console.WriteLine($"\nAverage Grade: {averageG:F2}");
            Console.WriteLine($"\nHello {sName} your result is {result}.");

            // End of code
            Console.WriteLine("Press any key to exit...");
        }
    }
}
