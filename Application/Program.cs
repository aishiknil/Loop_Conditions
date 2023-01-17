using System;
namespace Application
{
    public class Program
    {
        static void Main(string[] args)
        {
            int ch,c;
            do
            {
                Console.WriteLine("Enter 1 for If_Else, 2 for For-For_each, 3 for goto");
                ch = Convert.ToInt16(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        System.Console.WriteLine("Enter 3 Values to find the greatest: ");
                        int v1 = Convert.ToInt32(Console.ReadLine());
                        int v2 = Convert.ToInt32(Console.ReadLine());
                        int v3 = Convert.ToInt32(Console.ReadLine());
                        if (v1 > v2)
                        {
                            if (v1 > v3)
                                Console.WriteLine("{0} is the greatest", v1);
                            else
                                Console.WriteLine("{0} is the greatest", v3);
                        }
                        else
                        {
                            if (v2 > v3)
                                Console.WriteLine("{0} is the greatest", v2);
                            else
                                Console.WriteLine("{0} is the greatest", v3);
                        }
                        break;

                    case 2:
                        System.Console.WriteLine("How many elements do you want to enter: ");
                        int n = Convert.ToInt32(Console.ReadLine());
                        int[] Arr = new int[n];
                        System.Console.WriteLine("Enter elements: ");
                        for (int j = 0; j < n; j++)
                        {
                            Arr[j] = Convert.ToInt32(Console.ReadLine());
                        }
                        foreach (int j in Arr)
                        {
                            System.Console.Write(j + " | ");
                        }
                        break;

                    case 3:
                        int i=0;
                        while (i <=5)
                        {
                            // if(i==2)
                            //     continue;
                            if(i==4)
                            {
                                goto Label1;
                            }
                            System.Console.WriteLine(i);
                            i++;
                        }
                         Label1:
                                System.Console.WriteLine("This is GOTO");
                        break;
                    
                    default:
                        System.Console.WriteLine("Wrong Input");
                        break;
                }
                Console.WriteLine("Enter 0 to continue");
                c  = Convert.ToInt32(Console.ReadLine());
            } while (c == 0);
        }
    }
}