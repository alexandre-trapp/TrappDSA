namespace TrappDSA.Algorithms;

public class BinarySearch
{
    public void Execute()
    {
        var ordenedArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        var targetNumber = new Random().Next(1, 10);

        var middle = ordenedArray.Length / 2;
        Console.WriteLine("Findind target number");

        int attempts = 0;

        while (middle >= 0)
        {
            attempts++;
            Console.WriteLine($"ordenedArray[{middle}] => {ordenedArray[middle]}");

            if (ordenedArray[middle] == targetNumber)
            {
                Console.WriteLine($"TargetNumber {targetNumber} founded on position ordenedArray[{middle}] with {attempts} attempts!!");
                return;
            }

            if (ordenedArray[middle] > targetNumber)
                middle--;
            else
                middle++;
        }

        Console.WriteLine($"targetNumber {targetNumber} not found");

    }
}
