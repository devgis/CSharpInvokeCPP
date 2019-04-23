using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace CSharpInvokeCPP.CSharpDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = CPPDLL.Add(10, 20);
            Console.WriteLine("10 + 20 = {0}", result);

            result = CPPDLL.Sub(30, 12);
            Console.WriteLine("30 - 12 = {0}", result);

            result = CPPDLL.Multiply(5, 4);
            Console.WriteLine("5 * 4 = {0}", result);

            result = CPPDLL.Divide(30, 5);
            Console.WriteLine("30 / 5 = {0}", result);

            IntPtr ptr = CPPDLL.Create("李平", 27);
            CPPDLL.User user = (CPPDLL.User)Marshal.PtrToStructure(ptr, typeof(CPPDLL.User));
            Console.WriteLine("Name: {0}, Age: {1}", user.Name, user.Age);

            Console.ReadLine();
        }
    }
}
