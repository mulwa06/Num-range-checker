namespace Part1_Task1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // greeting
            Console.WriteLine("Hello there !");

            // prompt user to enter number
            Console.WriteLine("Please enter a number:");
            double user_input = Convert.ToDouble(Console.ReadLine());

            // check if number is greater than or equal to 0 and less than 10.5
            if (user_input >= 0 && user_input < 10.5)
            {
                Console.WriteLine("The number you entered is between 0 and 10.5");
            }
            else
            {
                Console.WriteLine("The number you entered is not between 0 and 10.5");
            }
        }
    }
}
