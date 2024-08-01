public class Prime_number
{
public static bool IsPrime(int number)
    {
        if (number <= 1)
            return false;
        
        if (number == 2 || number == 3 || number == 5 || number == 7)
            return true;
        
        if (number % 2 == 0 || number % 3 == 0)
            return false;

        if (number % 5 == 0 || number % 7 == 0)
            return false;

        return true;
    }

    public static void Main(string[] args)
    {
      Boolean t = true;
      while(t){
         System.Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        bool result = IsPrime(number);
        System.Console.WriteLine($"{number} is {(result ? "a prime" : "not a prime")} number.");
      }
       
    }

}
