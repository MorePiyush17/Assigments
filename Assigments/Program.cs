namespace Assigments
{
    internal class Program
    {
        static void Main(string[] args)
        {
         //Factorial of Number 
            Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            long factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            Console.WriteLine($"Factorial of {number} is : {factorial}");
        }
    }
}
