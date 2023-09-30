class leapyear
{
    public static void Main()
    {
        System.Console.WriteLine("Enter a year");
        int num=Convert.ToInt32(Console.ReadLine());

        if(num%4==0 && num%400!=0 && num%100==0)
        {
            System.Console.WriteLine($"This Year is leap year:{num}");
        }else
        {
            System.Console.WriteLine($"This Year is not leap year:{num}");
        }
    }
}