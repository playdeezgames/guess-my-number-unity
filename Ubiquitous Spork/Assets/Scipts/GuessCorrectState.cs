using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scipts
{
    public class GuessCorrectState : BaseState
    {
        public GuessCorrectState(StateMachine stateMachine) : base(stateMachine)
        {

        }

        public override void HandleInput(string input)
        {
        }

        public override void Refresh()
        {
            Terminal.Write("\nYou are correct!\n", false);
            Terminal.Write($"It took you {GameData.GetGuessCount()} guesses!\n", false);
            SetState(GameState.MAIN_MENU);
        }
    }
}
