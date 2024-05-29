namespace WhileDoWhile.DoWhile;

public class ApenasPares : IQuestao
{
    public ApenasPares()
    {
        int num;

        do
            GetNumero();
        while ((num = Convert.ToInt32(Console.ReadLine())) % 2 != 0);
        Console.WriteLine(num);
    }

    private void GetNumero()
    {
        Console.Clear();
        Console.WriteLine("escreva um número par");
    }
}