namespace WhileDoWhile.While;

public class NumerosNegativos : IQuestao
{
    public NumerosNegativos()
    {
        Console.WriteLine("escreva 10 valores separados por espaços");
        Console.WriteLine(
            Console.ReadLine()!
                .Split(' ')
                .Select(e => Convert.ToInt32(e.Trim()))
                .Where(e => e < 0)
                .ToList()
                .Count
        );
    }
}