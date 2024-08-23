using System;

namespace DataTypesApp
{
    class DataTypesProgram
    {
        static void Main(string[] args)
        { 
            //First code for greeting 
            Console.WriteLine("WELCOME STIERS!!!");
            Console.WriteLine("");
            
            // ask the user to enter an int for nummber of pieces of apple
            Console.Write("Enter the number of pieces of apple: ");
            double pApple = double.Parse(Console.ReadLine());

            // ask the user total price of the apple
            Console.Write("Enter the total price of the apples: ");
            double tApple = double.Parse(Console.ReadLine());

            //  output of total price of the apple 
            Console.WriteLine($"The total price of {pApple} pieces of apple is: {tApple}");

            //Convertion of the price to whole number
            int convertPrice = (int)Math.Round(tApple);

            // Display of the Price and converted Price
            Console.WriteLine($"Original price: {tApple}");
            Console.WriteLine($"Converted price: {convertPrice}");
        }
    }
}
