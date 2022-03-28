//methodOne: ShowCharacter
static void ShowCharacter()
{
    Console.WriteLine("Enter any word: ");
    String word = Console.ReadLine();
    Console.WriteLine("Enter a number position in your word to see what letter it is: ");
    int num = int.Parse(Console.ReadLine());
    char letter = word[num - 1];
    Console.WriteLine("Your word was " + word + ". Your number was " + num + ". And your letter is " + letter + ".");
}
ShowCharacter();
//end

//methodTwo RetailPrice
static void CalculateRetail()
{
    Console.WriteLine("Enter the item's wholesale cost: ");
    double cost = double.Parse(Console.ReadLine());
    Console.WriteLine("Enter the markup percentage: ");
    double percent = double.Parse(Console.ReadLine());
    double percentCost = cost * percent / 100;
    double total = percentCost + cost;
    Console.WriteLine("The item's wholesale cost is $" + cost + ". The markup percentage is " + percent + "%. The item's retail price is $" + total + ".");
}
CalculateRetail();
//end

//methodThree: TemperatureTable
static void TemperatureTable()
{
    Console.WriteLine("Enter your Fahrenheit temperature and it'll convert to Celsius! ");
    double temp = double.Parse(Console.ReadLine());
    double celsiusTemp = ((temp - 32)* 5/9);
    double temp2 = Math.Round(celsiusTemp, 2);
    Console.WriteLine(temp + " Degrees Farenheit = " + temp2 + " Degrees Cesius");
}
TemperatureTable();
//end

//methodFour: PrimeNumbers
static void IsPrime()
{
    Console.WriteLine("Enter a number to see if it is prime: ");
    int num = int.Parse(Console.ReadLine());
    bool prime = false;
    int n = num - 1;
    while(n > 1)
    {
        if((num % n) == 0)
        {
            prime = true;
        }
        n -= 1;
    }
    if(prime == true)
    {
        Console.WriteLine("False, it is not a prime number!");
    }
    else
    {
        Console.WriteLine("True, it is a prime number!");
    }
}
IsPrime(); //for true (enter number that would make value true)
IsPrime(); //for false (enter number that would make value false)
//end