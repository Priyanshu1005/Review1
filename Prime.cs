using System;
class Prime{
    static void Main(string[] args){
        Console.Write("enter a digit");
        int n=Convert.ToInt32(Console.ReadLine());
        int count=0;
        
        for(int i=2;i<=Int32.MaxValue;i++){
		int flag=0;
            for(int j=2;j<=i/2;j++)
            {
                if(i%j==0){
                    flag=1;
                }
            }
            if(flag==0){
                count++;
            }
            if(count==n){
                Console.Write($"Prime number is{i}");
                return;
            }
        }
    }
}