global using Dicee_Game.UserCommunication;

namespace Dicee_Game.Game
{

    public class GuessingGame
    {
        private readonly Dice _dice;
        private const int InitialTries = 3;
        public GuessingGame(Dice dice)
        {
            _dice = dice;
        }

        public GameResult Play()
        {
            var diceRollResult = _dice.Roll();
            Console.WriteLine($"Dice Rolled. Guess what number it shows in {InitialTries} tries.");


            var triesleft = InitialTries;
            while (triesleft > 0)
            {
                var guess = ConsoleReader.ReadInteger("Enter a number:");
                if (guess == diceRollResult)
                {
                    return GameResult.Victory;
                }
                Console.WriteLine("Wrong Number");
                --triesleft;
            }
            return GameResult.Loss;

        }

        public static void PrintResult(GameResult gameresult)
        {
            string message = gameresult == GameResult.Victory ? "You Win" : "You Lose";
            Console.WriteLine(message);
        }
    }

}
