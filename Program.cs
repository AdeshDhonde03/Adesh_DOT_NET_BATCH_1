using System;
using adesh;

    public class Program
    {
        public static void Main(string[] args){
    
        Int a = new Int(10);
        Int b = new Int(50);

        Console.WriteLine(a.Addition(a,b));
        Console.WriteLine(a.Substraction(a,b));
        Console.WriteLine(b.Multiplication(a,b));

        FLOAT p=new FLOAT(50);
        FLOAT q=new FLOAT(23);
        Console.WriteLine(p.Addition(p,q));
        Console.WriteLine(q.Substraction(p,q));
        Console.WriteLine(p.Division(p,q));
        }
    }
