using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
   Console.WriteLine("start number");
         int start=int.Parse(Console.ReadLine());
         Console.WriteLine("end number");
         int end=int.Parse(Console.ReadLine());
         
         int sum=0;
         for(int i=start; i<=end ;i++)
         {
         for(int x=1 ;x<=i; x++)
         {
          if(i%x==0)
          sum++;
           }
         if(sum==2){
         Console.WriteLine(i);
          sum=0;
         }
         else
         {
         sum=0;
         }
             
         }

    }
}