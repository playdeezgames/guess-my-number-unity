using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scipts
{
    public class InstructionsState : BaseState
    {
        public InstructionsState(StateMachine stateMachine) : base(stateMachine)
        {

        }
        public override void HandleInput(string input)
        {
        }

        public override void Refresh()
        {
            Terminal.Write("\nHow To Play:\n", false);
            Terminal.Write("I will pick a number between 1 and 100 inclusive.\n", false);
            Terminal.Write("You will then attempt to guess the number.\n", false);
            Terminal.Write("I will tell you if you are correct, higher, or lower.\n", false);
            Terminal.Write("Once you have guessed the number, I will tell you how many guesses you took.\n", false);
            SetState(GameState.MAIN_MENU);
        }
    }
}
