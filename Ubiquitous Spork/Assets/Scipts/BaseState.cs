using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scipts
{
    public abstract class BaseState: IState
    {
        private StateMachine _stateMachine;
        protected void SetState(GameState gameState)
        {
            _stateMachine.SetState(gameState);
        }
        public BaseState(StateMachine stateMachine)
        {
            _stateMachine = stateMachine;
        }
        public abstract void Refresh();
        public abstract void HandleInput(string input);

    }
}
