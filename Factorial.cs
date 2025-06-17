//Factorial

static void Main()
{
	 Console.WriteLine("Enter a number: ");
	{
	int num = intParse(Console.ReadLine());
	
	long factorial = 1;
	for(int i = 1; i<=num; i++);
	{
		factorial *= i;
	}
	
	Console.WriteLine("Factorial"+ num + "is:"+ factorial);
}

}

