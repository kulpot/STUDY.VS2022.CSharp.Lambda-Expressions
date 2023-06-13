using System;
using System.Collections.Generic;

//link ref:https://www.youtube.com/watch?v=KRjeu9Thp3s&list=PLAE7FECFFFCBE1A54&index=4
//lambda expression - method without a name
delegate bool MeDelegate(int n);
delegate double myMath(double a, double b);

class MainClass
{
    //static bool a(int n) { return n < 5; } 
    //static bool b(int n) { return n < 10; }
    // bool c(int n) { return n > 13; }
    static void Main()
    {
        int[] numbers = new[] { 2, 7, 3, 9, 17, 5, 7, 1, 8, 13 };
        IEnumerable<int> result =
            //RunNumbersThroughGauntlet(numbers, a);
            RunNumbersThroughGauntlet(numbers, n => n < 5); // lambda expression 
        foreach (int n in result)
            Console.WriteLine(n);

        myMath c = (a, b) => Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
        double val = c(2.36, 6.8);
        Console.WriteLine("More than one parameter in a Lambda expression " + val.ToString());
    }
    static IEnumerable<int> RunNumbersThroughGauntlet(
        IEnumerable<int> numbers, MeDelegate gauntlet)
    {
        foreach (int number in numbers)
            if (gauntlet(number))
                yield return number;
    }

}

// More than one parameter in a Lambda expression

/*delegate double myMath(double a, double b);

class program
{
    static void Main()
    {
        myMath c = (a, b) => Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
        double val = c(2.36, 6.8);
        Console.WriteLine(val.ToString());
    }
}*/