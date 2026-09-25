namespace ListNumsActions
{
    internal class Program
    {
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

                    case "del":

                        break;

                    case "remove":

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
