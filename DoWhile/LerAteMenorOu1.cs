namespace WhileDoWhile.DoWhile;

public class LerAteMenorOu1 : IQuestao
{
    private int _num;
    public LerAteMenorOu1()
    {
        Console.WriteLine("escreva um número, mas se ele for maior que 1 terá que digitar outro");
        do
            _num = Convert.ToInt32(Console.ReadLine());
        while (_num > 1);
    }
}