using System.Xml.Linq;

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
                        element = int.Parse(cmd[1]);

                        Console.WriteLine(nums.Contains(element) ? "YES" : "NO");
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

                        break;

                    case "countl":

                        break;

                    case "countOdds":

                        break;

                    case "countEvens":

                        break;

                    case "sumAll":

                        break;


                    default:
                        Console.WriteLine("Invalid command");
                        break;
                }
            }
        }
    }
}
