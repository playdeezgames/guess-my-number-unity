using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scipts
{
    public class GoodbyeState : BaseState
    {
        public GoodbyeState(StateMachine stateMachine) : base(stateMachine)
        {

        }

        public override void HandleInput(string input)
        {
        }

        public override void Refresh()
        {
            Terminal.Write("\nThank you for playing Guess My Number!\n", false);
        }
    }
}
