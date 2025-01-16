namespace Assignment2B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaring variables
            float number, width;

            //input and validate the numbers
            Console.Write("Enter a number: ");
            while(!float.TryParse(Console.ReadLine(), out number))
            {
                Console.Write("Only numbers are allowded!! Enter a number: ");
            }
            Console.Write("Enter your desired width: ");
            while(!float.TryParse(Console.ReadLine(),out width) || width<=0)
            {
                Console.Write("Only positive numbers Are Allowded!! Enter a valid width: ");
            }

            // Display the triangle
            Console.WriteLine("\nHere is your triangle:");
            for (int i = 1; i <= width; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(number + " ");
                }
                Console.WriteLine();
            }

            // Keep the console window open
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

    }
    
}

// take a number and width also a number as i/p
//displays a triangle of thet width, using that number.
