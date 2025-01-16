namespace Assignment1_4D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int y = -5; y <= 5; y++)
            {
                int x = (y * y) + (2 * y) + 1;
                Console.WriteLine($"y = {y}, x = {x}");
            }
        }
    }
}
     
//display certain values of a function x=y*y+2y+1
//using numbes for y from -5 to 5