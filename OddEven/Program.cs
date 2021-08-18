using System;

namespace OddEven
{
    public class Numbers
    {
        public static string EvenCheck(int num)
        {
            //num.ToString() + //thought i needed a tostring. but i do not..
            
            if (num % 2 == 0)
            {

                return $"Even";
            }
            else
            {
                return $"Odd";
            }
        }

        public static bool IsPrimeCheck(int num)
        {
            bool CalcPrime(int value)
            {
                var possibleFactors = Math.Sqrt(num);
                for (var factor = 2; factor <= possibleFactors; factor++)
                {
                    if (value % factor == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
            return num > 1 && CalcPrime(num);
        }

        public static string PrimePrint(int num2)
        {
            if (IsPrimeCheck(num2) == true)
            {
                return $"Prime";
            }
            else { return null; }
        }

    }

    //make a number class
    //make a find even function
    //make a find odd function
    //make a find prime function(have most)
    //count through 1-100.
    //print stuff using all the functions...
    //string n = Numbers.EvenCheck(5);
    // Console.WriteLine(n);
    //Console.Write(Numbers.PrimePrint(i));
    //Console.Write(Numbers.EvenCheck(i));
    // public static bool IsPrimeCheck(int numb)//my function failed...3 tests... try another one/tweak it
    //{
    //    if (numb <= 1) return false;
    //    if (numb == 2) return true;
    //    if (numb % 2 == 0) return false;
    //    for (int i = 3; i <= Math.Sqrt(numb); i += 2)
    //    {
    //        if (numb % 1 == 0) return false;
    //    }
    //    return true;
    //}
    public class Program
        {
            static void Main(string[] args)
            {
               //do a counting function. 
               //and put my functs in a for each loop...
               // with some if statements and writelines...

            for (int i = 1; i <=100; i++)//should i have put the counting function in as a test too?
            {
                Console.Write(i);
                if (Numbers.PrimePrint(i) == "Prime")
                {
                    Console.Write(" Prime\n");
                }
                 else if (Numbers.EvenCheck(i)== "Even")
                {
                    Console.Write(" Even\n");
                }
                else if (Numbers.EvenCheck(i)== "Odd")
                {
                    Console.Write(" Odd\n");
                }
            }

            }
    }
    
}
