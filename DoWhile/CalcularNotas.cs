namespace WhileDoWhile.DoWhile;

public class CalcularNotas : IQuestao
{
    public CalcularNotas()
    {
        string[] entrada;
        getEntrada:
        Console.WriteLine("digite as 4 notas");
        entrada = Console.ReadLine()!
            .Split(' ');
        if (entrada.Length != 4)
            goto getEntrada;
        Console.WriteLine(
            "a média das notas é " +
                entrada
                .Select(e => Convert.ToInt32(e.Trim()))
                .Select(e =>
                {
                    comparar:
                    if (e is >= 0 and <= 10)
                        return e;
                    Console.WriteLine(
                        $"a nota {e} não está entre 0 e 10, qual valor quer digitar para substitui-la"
                    );
                    e = Convert.ToInt32(Console.ReadLine());
                    goto comparar;

                })
                .Sum()
            / 4
        );
    }
}