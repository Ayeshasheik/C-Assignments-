using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment__4
{
    internal class Q1
    {
        static void Main(string[] args)
        {
            pushelements pu = new pushelements();
            pu.StackPush();
            pu.StackPop();
            Console.ReadLine();
        }
        public class pushelements
        {
            Stack st = new Stack();
            public void StackPush()
            {
                st.Push(1);
                st.Push(2);
                foreach (Object obj in st)
                {
                    Console.WriteLine(obj);
                }
                Console.WriteLine();
                Console.WriteLine("The number of elements in the stack " + st.Count);
                Console.ReadLine();
            }
            public void StackPop()
            {
                try
                {
                    st.Pop();
                    st.Pop();
                    st.Pop();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("You Have Pushed More Than Elements Having Hence Error is ----    " + ex);
                    Console.ReadLine();

                }
                finally
                {

                }
            }
        }
    }
}

    

