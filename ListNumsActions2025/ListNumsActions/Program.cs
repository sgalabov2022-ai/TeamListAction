using System.Globalization;
﻿using System.Xml.Linq;

namespace ListNumsActions
{
    internal class Program
    {
        private static int element;

        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (true)
            {
                string[] cmd = Console.ReadLine().Split().ToArray();
                string command = cmd[0];
                if (command.ToLower() == "finish")
                {
                    break;
                }
                switch (command)
                {
                    case "ins": int index= int.Parse(cmd[1]);
                        int num = int.Parse(cmd[2]);
                        nums.Insert(index,num);
                        break;

                    case "print":
                        Console.WriteLine(string.Join(" ", nums));
                        break;

                    case "contains":

                        break;

                    case "remove":
                        index = int.Parse(cmd[1]);

                        nums.RemoveAt(index);
                        break;

                    case "del":
                        element = int.Parse(cmd[1]);

                        nums.Remove(element);
                        break;

                    case "add":
                        int number1 = int.Parse(cmd[1]);
                        int number2 = int.Parse(cmd[2]);

                        nums.Add(number1 + number2);
                        break;

                    case "countl":
                        int number = int.Parse(cmd[1]);

                        int count = nums.Count(x => x > number);
                        Console.WriteLine(count);
                        break;

                    case "countOdds":
                        count = nums.Count(x => x % 2 != 0);
                        Console.WriteLine($"CountOdds={count}");
                        break;

                    case "countEvens":
                        count = nums.Count(x => x % 2 == 0);
                        Console.WriteLine($"CountEvens={count}");
                        break;

                    case "sumAll":
                        int sum = nums.Sum();
                        Console.WriteLine($"SumAll={sum}");
                        break;


                    default:
                        Console.WriteLine("Invalid command");
                        break;
                }
            }
        }
    }
}
