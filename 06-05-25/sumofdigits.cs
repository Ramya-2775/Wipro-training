using System;
class program
{
    public static int sumofdigits(int number)
    {
        int sum = 0;
        number = Math.Abs(number);

        while (number > 0)
        {
            int digit = number % 10;
            sum += digit;
            number = number / 10;
        }
        return sum;
    }
    static void Main()
    {
        int input = 1234;
        int result = sumofdigits(input);
        Console.WriteLine(result);
    }
}


