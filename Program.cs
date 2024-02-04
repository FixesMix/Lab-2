using Power;
//Aura Akunne, CPS*3330 - Section 1 Lab 2
public class Lab2P4
{
    public static void Main(String[] args)
    {


        Console.WriteLine("Enter a value for 'a' and press enter: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter a value for 'b' and press enter: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter a value for 'c' and press enter: ");
        int c = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine($"You provided the integers: {a} and {b}, the the total is {Power.Power.CalculatePower(a,b)}");
        Console.WriteLine($"You provided the integers: {a}, {b}, and {c}, the the total is {Power.Power.CalculatePower(a, b, c )}");

    }
}