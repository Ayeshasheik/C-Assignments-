using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment__5
{
    public class Q1
    {
        
        public static void Main()
        {
            Array_Actions array_actions = new Array_Actions();

            array_actions.Copy_ArrayToArray();
            array_actions.Sorting_Array();
            array_actions.Clear_Array();
            array_actions.Reverse_Array();

            Console.ReadLine();

        }

        public class Array_Actions
        {
            int[] Original_Array = { 5, 4, 7, 2, 9 };


            public void Copy_ArrayToArray()
            {
                
                int start = 1;
                int length = 3;

                int[] Copied_Array = new int[length];
                Array.Copy(Original_Array, start, Copied_Array, 0, length);

                Console.WriteLine("------------------------------------------------------------------------------------");
                Console.WriteLine("---------------------------------ORIGINAL ARRAY-------------------------------------");
                Console.WriteLine("------------------------------------------------------------------------------------");

               Console.WriteLine(String.Join(", ", Original_Array));

                Console.WriteLine("------------------------------------------------------------------------------------");
                Console.WriteLine("---------------------------------COPIED ARRAY-------------------------------------");
                Console.WriteLine("------------------------------------------------------------------------------------");

                Console.WriteLine(String.Join(", ", Copied_Array));

            }

            public void Sorting_Array()
            {
                
                Console.WriteLine("------------------------------------------------------------------------------------");
                Console.WriteLine("---------------------------------- Sorted ARRAY-------------------------------------");
                Console.WriteLine("------------------------------------------------------------------------------------");
                Array.Sort(Original_Array);
                foreach (int str in Original_Array)
                {
                    Console.WriteLine(String.Join(", ", str));
                }

            }
            public void Clear_Array()
            {
                int[] Original_Array = { 5, 4, 7, 2, 9 };
                Array.Clear(Original_Array, 1, 2);
                Console.WriteLine("------------------------------------------------------------------------------------");
                Console.WriteLine("---------------------- Array Post Clearing 1 & 2 Elements ARRAY-----------------------");
                Console.WriteLine("------------------------------------------------------------------------------------");
                foreach (int str in Original_Array)
                {
                    Console.WriteLine(str);
                }
            }

            public void Reverse_Array()
            {
                int[] Original_Array = { 5, 4, 7, 2, 9 };
                Array.Reverse(Original_Array);
                Console.WriteLine("------------------------------------------------------------------------------------");
                Console.WriteLine("---------------------------------- REVERSE ARRAYY-----------------------------------");
                Console.WriteLine("------------------------------------------------------------------------------------");
                foreach (int str in Original_Array)
                {
                    Console.WriteLine(str);
                }
            }
        }
    }
}