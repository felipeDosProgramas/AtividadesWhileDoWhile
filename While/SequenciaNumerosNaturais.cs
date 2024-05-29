namespace WhileDoWhile.While;

public class SequenciaNumerosNaturais : IQuestao
{
    public SequenciaNumerosNaturais()
    {
        Console.WriteLine("Escreva dois números inteiros separados por espaço \n" +
                          "escreva o primeiro sendo menor que segundo");
        int[] nums = new int[2];
        do
            nums = Console.ReadLine()!
                .Split(" ")
                .Select(e => Convert.ToInt32(e))
                .ToArray();
        while (nums[0] > nums[1] || nums[0] == nums[1]);

        for (int i = nums[0]; i < nums[1]+1; i++)
            Console.Write(i + " ");
    }
}