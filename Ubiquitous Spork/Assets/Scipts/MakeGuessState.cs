using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scipts
{
    public class MakeGuessState : BaseState
    {
        public MakeGuessState(StateMachine stateMachine):base(stateMachine)
        {
        }

        public override void HandleInput(string input)
        {
            if(int.TryParse(input, out int guess))
            {
                switch(GameData.MakeGuess(guess))
                {
                    case GuessResult.TOO_HIGH:
                        SetState(GameState.GUESS_HIGH);
                        break;
                    case GuessResult.TOO_LOW:
                        SetState(GameState.GUESS_LOW);
                        break;
                    default:
                        SetState(GameState.GUESS_CORRECT);
                        break;
                }
            }
            else
            {
                Terminal.Write("\nPlease enter a valid selection.\n", false);
                Refresh();
            }
        }

        public override void Refresh()
        {
            Terminal.Write("Guess my number (1-100)\n", false);
            Terminal.Write("\n>", false);
        }
    }
}
