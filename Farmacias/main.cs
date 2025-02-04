using System;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;

class Program
{
    static void Main(string[] args)
    {
        Process.Start("notepad.exe", "login.cs");
    } 
}