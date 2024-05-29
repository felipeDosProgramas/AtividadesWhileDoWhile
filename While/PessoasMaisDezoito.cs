namespace WhileDoWhile.While;

public class PessoasMaisDezoito : IQuestao
{
    public PessoasMaisDezoito()
    {
        Console.WriteLine("me diga a idade de 10 pessoas, separe as idades por espaços");
        Console.WriteLine(
            Console.ReadLine()!
                .Split(" ")
                .Select(e => Convert.ToInt32(e))
                .Where( e => e > 18)
                .Select(e => Convert.ToString(e))
                .Aggregate((e, p) => e + ' ' + p)
        );
    }
}