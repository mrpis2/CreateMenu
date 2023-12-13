using System;
class Program
{
    private static void Main(string[] args)
    {
        int Choice = 8;
        while (Choice != 0)
        {
            Console.WriteLine("Nhap gia tri");
            Choice = Convert.ToInt32(Console.ReadLine());
            switch (Choice)
            {
                case 1:
                    {
                        Console.WriteLine("********");
                        Console.WriteLine("********");
                        Console.WriteLine("********");
                        Console.WriteLine("********");
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine("********");
                        Console.WriteLine("*******");
                        Console.WriteLine("******");
                        Console.WriteLine("*****");
                        Console.WriteLine("****");
                        Console.WriteLine("***");
                        Console.WriteLine("**");
                        Console.WriteLine("*");
                    }
                    break;
                case 3:
                    {
                        Console.WriteLine("********");
                        Console.WriteLine("********");
                        Console.WriteLine("********");
                        Console.WriteLine("********");
                        Console.WriteLine("********");
                        Console.WriteLine("********");
                    }
                    break;
                case 0:
                    {
                        Environment.Exit(0);
                    }
                    break;
                default:
                    {
                        Console.WriteLine("Nhap Lai");
                    }
                    break;
            }
        }
      

    }
}