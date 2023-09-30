class numtowordconvert
{
    private static string numtoword(int a)
    {
        string word="";
        string[] unitarray={"zero","one","two","three","four","five","six","seven","eight",
        "nine","ten","eleven","twelve","thirteen","fourteen","fifteen","sixteen","seventeen","eighteen","nineteen"};

        string[] tensarray={"zero","ten","twenty","thirty","fourty","fifty","sixty","seventy","eighty","ninety"};

        if(a==0)
        {
            return "zero";
        }
        if(a<0)
        {
            string number= ""+a;
            number=number.Substring(1);
            return "minus"+numtoword(Convert.ToInt32(number));
        }
        if((a/1000000)>0)
        {
            word=word+numtoword(a/1000000)+"million";
            a=a%1000000;
        }
        if((a/1000)>0)
        {
            word=word+numtoword(a/1000)+"Thousand";
            a=a%1000;
        }
        if((a/100)>0)
        {
            word=word+numtoword(a/100)+"Hundred";
            a=a%100;
        }
        if(a>0)
        {
            if(a<20)
            {
                word=word+unitarray[a];
            }else
            {
                word=word+tensarray[a/10];
                if((a%10)>0)
                {
                    word=word+"-"+unitarray[a%10];
                }
            }
        }
        return word;
    }
    public static void Main()
    {
        Console.WriteLine("Enter a number(upto 9 digits)");
        int number=Convert.ToInt32(Console.ReadLine());

        if(number==0)
        {
            Console.WriteLine("Zero");
        }else
        {
            Console.WriteLine("Number in Words:"+numtoword(number));
        }
    }
}