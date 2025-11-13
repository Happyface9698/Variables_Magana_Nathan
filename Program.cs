namespace Variables_Magana_Nathan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int favoriteNumber;               // Integer (whole number) 
            bool isJumping = false, isRunning = false; // Boolean (true/false)
            float myFloat;             // Float (decimal number)
            favoriteNumber = 420;              // Assigning value to favoriteNumber
            myFloat = 4.20f;               // Assigning value to myFloat to 42.0
            const double finalGrade = 42.0; // Constant (unchangeable value) final grade

            // Output the values to the console
            Console.WriteLine("favorite #: " + favoriteNumber);
            Console.WriteLine("Jumping: " + isJumping);
            Console.WriteLine("Running: " + isRunning);
            Console.WriteLine("Rando Floater Bee: " + myFloat);
            Console.WriteLine("LaBomb-ba Grande: " + finalGrade);
            

        }
    }
}
