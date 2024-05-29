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
            continuar = Console.ReadLine() == "sim";
            Console.Clear();
        }
    }
}