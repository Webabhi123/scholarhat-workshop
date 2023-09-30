class calculatorprogram
{
    public static void Main()
    {
        int num1,num2,num3;
        abhi:
        Console.WriteLine("Please enter a number");
        num1=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter 2nd number");
        num2=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Choose a option(1,2,3,4)");
        int ch=Convert.ToInt32(Console.ReadLine());;

        switch(ch)
        {
            case 1:
            num3=num1+num2;
            Console.WriteLine("The Sum of {0} and {1}={2}",num1,num2,num3);
            break;
            case 2:
            num3=num1-num2;
            Console.WriteLine("The Subtraction of {0} and {1}={2}",num1,num2,num3);
            break;
            case 3:
            num3=num1*num2;
            Console.WriteLine("The Multiplication of {0} and {1}={2}",num1,num2,num3);
            break;
            case 4:
            num3=num1/num2;
            Console.WriteLine("The Division of {0} and {1}={2}",num1,num2,num3);
            break;
            default:
            Console.WriteLine("Error number!");
            break;
        }
        Console.WriteLine("Do you want to Continue(y/n)");
        string confirm=Console.ReadLine().ToLower();
        if(confirm=="y")
        {
            
        }else
        {
            Console.WriteLine("Exit..");
        }
    }
}