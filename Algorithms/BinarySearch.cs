namespace TrappDSA.Algorithms;

public static class BinarySearch
{
    public static void Execute()
    {
        var ordenedArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        var targetNumber = int.Parse(Console.ReadLine()!);

        var middle = ordenedArray.Length / 2;
        Console.WriteLine($"Findind target number");

        while (middle >= 0)
        {
            Console.WriteLine($"ordenedArray[{middle}] => {ordenedArray[middle]}");

            if (ordenedArray[middle] == targetNumber)
            {
                Console.WriteLine($"TargetNumber {targetNumber} founded on position ordenedArray[{middle}]");
                return;
            }

            if (ordenedArray[middle] > targetNumber)
                middle--;
            else
                middle++;
        }
    }
}
