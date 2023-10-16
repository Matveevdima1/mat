using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            general a= new general();
            a.al1();
            a.al2();
            a.al3();
            a.al4();
            a.bl1();
            a.bl2();
            a.bl3();
            a.bl4();
            a.sl1();
            a.sl2();
            a.sl3();
            a.sl4();
            a.gl1();
            a.gl2();
            a.gl3();
            a.gl4();
        }

    }
}

class general
{
    public ArrayList List=new ArrayList();
    public List<int> List2 = new List<int>();
    public Queue<string> Queue1 = new Queue<string>();
    public Stack<double> Stack1 = new Stack<double>();
    public void al1()
    {
        List.Add(1);
        List.Add("lol");
        List.Add(102);
        List.Add("dima");
    }
    public void al2()
    {
        List.RemoveAt(1);
    }
    public void al3()
    {
        Console.WriteLine(List[1]);
    }
    public void al4()
    {
        Console.WriteLine(List.Count);
    }
    public void bl1() 
    {
        List2.Add(1);
        List2.Add(2);
        List2.Add(102);
        List2.Add(5);
    }
    public void bl2()
    {
        List2.RemoveAt(1);
    }
    public void bl3()
    {
        Console.WriteLine(List[1]);
    }
    public void bl4()
    {
        Console.WriteLine(List2.Count);
    }
    public void sl1()
    {
        Queue1.Enqueue("adam");
        Queue1.Enqueue("lol");
        Queue1.Enqueue("poas");
        Queue1.Enqueue("dima");
    }
    public void sl2()
    {
        Queue1.Dequeue();
    }
    public void sl3()
    {
        Console.WriteLine(Queue1.Peek());
    }
    public void sl4()
    {
        Console.WriteLine(Queue1.Count);
    }
    public void gl1()
    {
        Stack1.Push(12);
        Stack1.Push(31);
        Stack1.Push(61);
        Stack1.Push(90);
    }
    public void gl2()
    {
        Stack1.Pop();
    }
    public void gl3()
    {
        Console.WriteLine(Stack1.Peek());
    }
    public void gl4()
    {
        Console.WriteLine(Stack1.Count);
    }
}