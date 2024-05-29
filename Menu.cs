namespace WhileDoWhile;

public class Menu
{
    public IQuestao GetQuestao()
    {
        Console.WriteLine("quer ver as questões do While ou do Do/While \n (0 ou 1)");
        return Convert.ToInt32(Console.ReadLine()) switch
        {
             0 => GetQuestaoWhile(),
             1 => GetQuestaoDoWhile(),
            _ => GetQuestao()
        };
    }

    private IQuestao GetQuestaoWhile()
    {
        Console.WriteLine("escolha o número da questão (1, 2, 3 ou 4)");
        return Convert.ToInt32(Console.ReadLine()) switch
        {
            1 => new While.SequenciaNumerosNaturais(),
            2 => new While.PessoasMaisDezoito(),
            3 => new While.NumerosNegativos(),
            4 => new While.SequenciaAte10(),
            _ => GetQuestaoWhile()
        };
    }

    private IQuestao GetQuestaoDoWhile()
    {
        Console.WriteLine("escolha o número da questão (1, 2, 3 ou 4)");
        return Convert.ToInt32(Console.ReadLine()) switch
        {
            1 => new DoWhile.ApenasPares(),
            2 => new DoWhile.CalcularNotas(),
            3 => new DoWhile.LerAteMenorOu1(),
            4 => new DoWhile.AteO0(),
            _ => GetQuestaoDoWhile()
        };
    }
}