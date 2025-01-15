namespace Assignments1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //assigning values to variables
            string originalUserName = "username";
            string originalPassword = "password";

            //assigning variables for userinput
            string userName, password;
            int attempt = 0; // for counting failed attempts
            const int maxAttempts = 3; // maximum attempts a user can use


            //user authenticating loop
            while (attempt < maxAttempts)
            {

                //get user inputs
                Console.Write("Enter User Name: ");
                userName = Console.ReadLine();

                Console.Write("Enter Password: ");
                password = Console.ReadLine();


                //validating
                if (userName == originalUserName && password == originalPassword)
                {
                    Console.WriteLine("Login Successfull!");
                    break;
                }
                //counting wrong attempts
                else
                {
                    attempt++;
                    Console.WriteLine($"Invalid username or password. Attempt {attempt} out of {maxAttempts}!!");
                }

                //execceding maxAttempt limit
                if (attempt == maxAttempts)
                {
                    Console.WriteLine("You have been rejected after 3 wrong attempts!!");
                }
            }
            // Keep the console window open
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
    



// user id & password as i/p - string 
//after 3 wrong attempts, user will be rejected 