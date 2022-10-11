using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatePractise
{
    internal class Program
    {
        public delegate bool Check(int num);
        public delegate void Write(string m);
        public delegate int TestInt(int n, int m);

        public delegate void Read<in T,out U>(T m);

        static void Main(string[] args)
        {
            //Console.WriteLine(SumEven(1,2,3,4));
            //Console.WriteLine(SumOdd(1,2,3,4));

            //Console.WriteLine(Sum(n=>n%2==0,1,2,3,4));
            //Console.WriteLine(Sum(n=>n%2!=0,1,2,3,4));

            Write write = GetLength;
            write += ToUpper;
            //Anonim methodlar
            write += delegate (string l){ Console.WriteLine(l.ToLower()); };
            //lambda expression
            write += b => Console.WriteLine(b);
            write -= ToUpper;
            //write("Sabina");

            TestInt test = Doler;

            test += delegate (int n, int m)
            {
               
                return n - m;
            };

            //test += (u, o) => u * o;

            //Console.WriteLine(test(2,3));

            //Read<string> read = n => Console.WriteLine(n);

            Action<int, string,int> action =( n,m,z) => Console.WriteLine(n+" " +m);
            //action(5, "Reshad");

            Func<int,int, string>func= (n,m)=>n.ToString();

            Predicate<int> predicate = n => n > 3;


            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(5);
            numbers.Add(2);
            numbers.Add(5); 
            numbers.Add(4);

           List<int>arr= numbers.FindAll(k => k == 5);
            //Console.WriteLine(arr);

            int[] arr1 = { 6, 5, 1, 7};
            Array.Sort(arr1);
            foreach (var item in arr1)
            {
                Console.WriteLine(item);
            }
            
        }

        public static int Doler(int a, int b) {
            Console.WriteLine(a+b);
            return (a + b);
        }


        static void GetLength(string word)
        {
            Console.WriteLine(word.Length);
        }
        static void ToUpper(string word)
        {
            Console.WriteLine(word.ToUpper());
        }



        public bool Test(int num,int num2)
        {
            return 5 > 6;
        }
    

        static int Sum(Predicate<int> func,params int[] numbers)
        {
            int sum = 0;
            foreach (var item in numbers)
            {
                if (func(item))
                {
                    sum += item;
                }
            }
            return sum;
        }

        //static int SumOdd(params int[] numbers)
        //{
        //    int sum = 0;
        //    foreach (var item in numbers)
        //    {
        //        if (IsOdd(item))
        //        {
        //            sum += item;
        //        }
        //    }
        //    return sum;
        //}

        //static int SumGreatrherThan(params int[] numbers)
        //{
        //    int sum = 0;
        //    foreach (var item in numbers)
        //    {
        //        if (item >2)
        //        {
        //            sum += item;
        //        }
        //    }
        //    return sum;
        //}
    }
}
