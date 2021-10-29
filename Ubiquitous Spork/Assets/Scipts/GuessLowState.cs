using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scipts
{
    public class GuessLowState : BaseState
    {
        public GuessLowState(StateMachine stateMachine) : base(stateMachine)
        {

        }

        public override void HandleInput(string input)
        {
        }

        public override void Refresh()
        {
            Terminal.Write("\nThat guess is too low!\n", false);
            SetState(GameState.MAKE_GUESS);
        }
    }
}
