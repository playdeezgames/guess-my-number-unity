namespace Assets.Scipts
{
    class WelcomeState : BaseState
    {
        public WelcomeState(StateMachine stateMachine) : base(stateMachine)
        {

        }
        public override void HandleInput(string input)
        {
            Refresh();
        }

        public override void Refresh()
        {
            Terminal.Write("Welcome to Guess My Number!\n", false);
            SetState(GameState.MAIN_MENU);
        }
    }
}
