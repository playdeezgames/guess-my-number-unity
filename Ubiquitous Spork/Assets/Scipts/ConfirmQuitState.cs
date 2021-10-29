using System;

namespace Assets.Scipts
{
    class ConfirmQuitState : BaseState
    {
        public ConfirmQuitState(StateMachine stateMachine) : base(stateMachine)
        {

        }
        public override void HandleInput(string input)
        {
            switch(input)
            {
                case "1":
                    SetState(GameState.MAIN_MENU);
                    break;
                case "2":
                    SetState(GameState.GOODBYE);
                    break;
                default:
                    Terminal.Write("\nPlease enter a valid selection.\n", false);
                    Refresh();
                    break;
            }
        }

        public override void Refresh()
        {
            Terminal.Write("\nAre you sure you want to quit?\n", false);
            Terminal.Write("1) No\n", false);
            Terminal.Write("2) Yes\n", false);
            Terminal.Write("\n>", false);
        }
    }
}
