int pin;

do
{
    Console.Write("Enter your PIN: ");
    pin = int.Parse(Console.ReadLine());

    if (pin < 1000 || pin > 9999)
    {
        Console.WriteLine("Must be between 1000 and 9999. Please try again.");
    }
} while (pin < 1000 || pin > 9999);
