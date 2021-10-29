using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scipts
{
    public class GuessHighState : BaseState
    {
        public GuessHighState(StateMachine stateMachine) : base(stateMachine)
        {

        }

        public override void HandleInput(string input)
        {
        }

        public override void Refresh()
        {
            Terminal.Write("\nThat guess is too high!\n", false);
            SetState(GameState.MAKE_GUESS);
        }
    }
}
