namespace WhileDoWhile.DoWhile;

public class AteO0 : IQuestao
{
    public AteO0()
    {
        Console.WriteLine("digite (um por vez) os números para serem somados \n quando terminar digite o zero");
        List<int> numeros = [];
        int num;
        do
            numeros = numeros.Append(
                num = Convert.ToInt32(Console.ReadLine())
                )
            .ToList();
        while (num != 0);
        Console.WriteLine("a soma dos números digitados é " + numeros.Sum());
    }
}