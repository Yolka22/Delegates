using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class Program
    {

        public static bool IsPrime(int number)
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }



        delegate int ArrayDelegate(List<int> list);

        static int Array_Prime_Number(List<int> list) {

            int Prime = 0;

            for (int i = 0; i < list.Count; i++)
            {
                if (IsPrime(list[i])) Prime++;
            }

            return Prime;
        }

        static int Array_Even_Number(List<int> list)
        {

            int Even = 0;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i]%2==0)
                {
                    Even++;
                }
            }

            return Even;
        }

        static int Array_Not_Even_Number(List<int> list)
        {

            int Not_Even = 0;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 != 0)
                {
                    Not_Even++;
                }
            }

            return Not_Even;
        }

        static int Array_Fibonachi_Number(List<int> list)
        {
            list.Sort();
            int Fibonachi = 0;

            for (int i = 2; i < list.Count; i++)
            {
                if (list[i] == list[i - 1] + list[i-2])
                {
                    Fibonachi++;
                }
            }

            return Fibonachi;
        }


        class Array
        {
            List<int> list;

            public Array ()
            {

                list = new List<int> ();
                Random random= new Random ();

                for (int i = 0; i < random.Next(1000,2000); i++)
                {

                    list.Add(random.Next(1,10000));

                }
            }


            public void Prime_Numb()
            {
                ArrayDelegate arr;
                arr = Array_Prime_Number;

                Console.WriteLine("простых чисел "+arr(list));
            }

            public void Even_Numb()
            {
                ArrayDelegate arr;
                arr = Array_Even_Number;

                Console.WriteLine("четных чисел "+arr(list));
            }

            public void Not_Even_Numb()
            {
                ArrayDelegate arr;
                arr = Array_Not_Even_Number;

                Console.WriteLine("не четных чисел " + arr(list));
            }


            public void Fibonachi_Numb()
            {
                ArrayDelegate arr;
                arr = Array_Fibonachi_Number;

                Console.WriteLine("чисел подходящих под условие фибоначи " + arr(list));
            }

            public void Print()
            {
                foreach (var item in list)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
        }


        static void Main(string[] args)
        {

            Array array = new Array ();

            array.Print();
            array.Prime_Numb();
            array.Even_Numb();
            array.Not_Even_Numb();
            array.Fibonachi_Numb();

            Console.ReadLine();
        }
    }
}
