using System;
//this is where it's encrypted
class Program
{
   static void Main(string[] args)
   {
      int digit1;
      int digit2;
      int digit3;
      int digit4;

      Console.WriteLine("Enter a four digit number. Hit \"Enter\" after each digit.");
      digit1 = Convert.ToInt32(Console.ReadLine());
      digit2 = Convert.ToInt32(Console.ReadLine());
      digit3 = Convert.ToInt32(Console.ReadLine());
      digit4 = Convert.ToInt32(Console.ReadLine());

      digit1 += 7;
      digit2 += 7;
      digit3 += 7;
      digit4 += 7;

      digit1 = digit1 % 10;//get remainder of digit divided by 10
      digit2 = digit2 % 10;
      digit3 = digit3 % 10;
      digit4 = digit4 % 10;

      //Console.Write("{0}{1}{2}{3}", digit1, digit2, digit3, digit4);//to test encyrption phase1
      //swap 1st with 3rd and 2nd with 4th
      int newDigit1 = digit3;
      int newDigit3 = digit1;
      int newDigit2 = digit4;
      int newDigit4 = digit2;//8901   0189

      Console.Write("{0}{1}{2}{3}", newDigit1, newDigit2, newDigit3, newDigit4);

      Console.ReadKey();

   }
}
