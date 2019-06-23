using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] strings = s.Split(' ');
            int charsum=0;
            int smitsum = 0;
            for(int i = 0; i < strings.Length; i++)
            {
                int number= int.Parse(strings[i]);
                int r = 2;
                bool ok = true;
                while((r<number)&(ok))
                {
                    if (number % r == 0) ok = false;
                    r++;
                }
                if (ok == false)
                {
                    for (int j = 0; j < strings[i].Length; j++)
                    {
                        charsum += int.Parse(strings[i][j].ToString());
                    }
                    while (number != 1)
                    {
                        int j = 3;
                        ok = true;
                        if (number % 2 == 0)
                        {
                            number = number / 2;
                            smitsum += 2;
                        }
                        else
                        {
                            while ((j <= number) & (ok))
                            {
                                if (number % j == 0)
                                {
                                    for (int k = 0; k < j.ToString().Length; k++)
                                    {
                                        smitsum += int.Parse(j.ToString()[k].ToString());
                                    }
                                    ok = false;
                                    number = number / j;
                                }
                                j++;
                            }
                        }
                    }
                    if (charsum == smitsum)
                    {
                        Console.Write("1");
                    }
                    else Console.Write("0");
                    charsum = 0;
                    smitsum = 0;
                }
                else { Console.Write("0"); }
            }

            Console.ReadLine();
        }
    }
}
