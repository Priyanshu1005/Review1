using System;

abstract class Sub{
    public abstract void sub(int a,int b);
}
interface IDemo{
    static void add(int a,int b);
}
class Calculator : Sub, IDemo{
    public  void sub(int a, int b)
    {
        Console.WriteLine(a - b);
    }
	public void add(int a,int b){
        Console.WriteLine(a+b);
    }
}



class Inherit{
    static void Main(String[] args){
        int a=Convert.ToInt32(Console.ReadLine());
        int b=Convert.ToInt32(Console.ReadLine());
        Calculator sb=new Calculator();
        Console.WriteLine("Subtraction of two numbers is "+sb.sub(a,b));
        Console.WriteLine("Addition of two numbers is "+sb.add(a,b));

    }
}