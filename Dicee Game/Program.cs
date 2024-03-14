using Dicee_Game.Game;

namespace Dicee_Game
{
    public class Program
    {
        static void Main(string[] args)
        {
           var _random = new Random();
           var dice = new Dice(_random);
           var guessinGame = new GuessingGame(dice);

           GameResult gameresult = guessinGame.Play();

           GuessingGame.PrintResult(gameresult);
           Console.ReadKey();

        }
    }

   
}
