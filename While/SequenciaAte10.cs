namespace WhileDoWhile.While;

public class SequenciaAte10 : IQuestao
{
    private int _contador = -1;
    private const string Numeros = " 1 2 3 4 5 6 7 8 9 10";
    public SequenciaAte10()
    {
        while (_contador++ != 10)
            Console.WriteLine(_contador + Numeros);
    }
}