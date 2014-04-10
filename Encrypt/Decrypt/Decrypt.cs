using System;
//This is the decryption part of exercise 5.41.
class Program
{
   static void Main(string[] args)
   {
      int num1, num2, num3, num4;
      int one = 1;

      Console.WriteLine("Enter number 1 - 4 of the encrypted 4-digit number.");
      num1 = Convert.ToInt32(Console.ReadLine());//0
      num2 = Convert.ToInt32(Console.ReadLine());//1
      num3 = Convert.ToInt32(Console.ReadLine());//8
      num4 = Convert.ToInt32(Console.ReadLine());//9

      int new1 = int.Parse(one.ToString() + num1.ToString());//10
      int new2 = int.Parse(one.ToString() + num2.ToString());//11
      int new3 = int.Parse(one.ToString() + num3.ToString());//18
      int new4 = int.Parse(one.ToString() + num4.ToString());//19

      new1 = new1 - 7;//10-7=3
      new2 = new2 - 7;//11-7=4
      new3 = new3 - 7;//18-7=11
      new4 = new4 - 7;//19-7=12

      int newNew1 = new3;
      int newNew2 = new4;
      int newNew3 = new1;
      int newNew4 = new2;

      newNew1 = newNew1 % 10;
      newNew2 = newNew2 % 10;
      newNew3 = newNew3 % 10;
      newNew4 = newNew4 % 10;

      Console.Write(newNew1);
      Console.Write(newNew2);
      Console.Write(newNew3);
      Console.Write(newNew4);
      Console.ReadKey();
   }
}
