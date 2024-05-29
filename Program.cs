namespace WhileDoWhile;

class Program
{
    static void Main(string[] args)
    {
        bool continuar = true;
        while (continuar)
        {
            new Menu()
                .GetQuestao();
            Console.WriteLine("quer continuar? (sim ou não)");
            continuar = Console.ReadLine() == "sim";
            Console.Clear();
        }
    }
}