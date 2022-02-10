using chess_console.tabuleiro;

namespace chess_console
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8,8);

            Tela.ImprimirTabuleiro(tab);

            Console.ReadLine();

        }
    }
}
