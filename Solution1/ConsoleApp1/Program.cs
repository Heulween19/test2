using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static async Task<List<int>> MethodA()
        {
            List<int> ListA = new List<int>();

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
                ListA.Add(i);
                await Task.Delay(2000);


            }
            return ListA;
        }
        static async Task<List<int>> MethodB()
        {
            List<int> ListB = new List<int>();

            for (int i = 10; i <= 15; i++)
            {
                Console.WriteLine(i);
                ListB.Add(i);
                await Task.Delay(2000);


            }
            return ListB;
        }

        //static async Task MethodC(List<int> lst1, List<int> lst2)
        //{
        //    foreach (int i in lst1)
        //    {
        //        Console.WriteLine($"lista: {i}");
        //    }
        //    foreach (int i in lst2)
        //    {
        //        Console.WriteLine($"listb: {i}");
        //    }

        //}
        static async Task Methodc(List<int>[] lst)
        {
            foreach (List<int> subList in lst)
            {
                var i = Array.IndexOf(lst, subList);
                Console.WriteLine($"List {i}");
                foreach (int item in subList)
                {
                    Console.WriteLine(item);
                }
            }

        }


        static async Task Main(string[] args)
        {
            var x = MethodA();
            var y = MethodB();
            
            var lst = await Task.WhenAll(x, y);
            Task.WaitAll(x, y);
            
            //MethodC(x.Result,y.Result);

            Methodc(lst);





        }
    }
}
