using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace CSharpInvokeCPP.CSharpDemo
{
    public class CPPDLL
    {
        [DllImport("CSharpInvokeCPP.CPPDemo.dll")]
        public static extern int Add(int x, int y);

        [DllImport("CSharpInvokeCPP.CPPDemo.dll")]
        public static extern int Sub(int x, int y);

        [DllImport("CSharpInvokeCPP.CPPDemo.dll")]
        public static extern int Multiply(int x, int y);

        [DllImport("CSharpInvokeCPP.CPPDemo.dll")]
        public static extern int Divide(int x, int y);

        [DllImport("CSharpInvokeCPP.CPPDemo.dll")]
        public static extern IntPtr Create(string name, int age);

        [StructLayout(LayoutKind.Sequential)]
        public struct User
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string Name;

            public int Age;
        }
    }
}
