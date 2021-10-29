using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scipts
{
    public static class GameData
    {
        private static Random _random = new Random();
        private static int _target;
        private static int _guesses;
        public static void Reset()
        {
            _target = _random.Next(1, 101);
            _guesses = 0;
        }
        public static GuessResult MakeGuess(int guess)
        {
            _guesses++;
            if(guess>_target)
            {
                return GuessResult.TOO_HIGH;
            }
            else if(guess<_target)
            {
                return GuessResult.TOO_LOW;
            }
            else
            {
                return GuessResult.CORRECT;
            }
        }

        public static int GetGuessCount()
        {
            return _guesses;
        }
    }
}
