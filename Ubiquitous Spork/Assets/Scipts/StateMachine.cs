using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scipts
{
    public class StateMachine: IState
    {
        private GameState _gameState = GameState.WELCOME;
        private readonly Dictionary<GameState, IState> _states = new Dictionary<GameState, IState>();

        private void AddState(GameState gameState, IState state)
        {
            _states[gameState] = state;
        }

        public StateMachine()
        {
            AddState(GameState.WELCOME, new WelcomeState(this));
            AddState(GameState.MAIN_MENU, new MainMenuState(this));
            AddState(GameState.CONFIRM_QUIT, new ConfirmQuitState(this));
            AddState(GameState.GOODBYE, new GoodbyeState(this));
            AddState(GameState.INSTRUCTIONS, new InstructionsState(this));
            AddState(GameState.MAKE_GUESS, new MakeGuessState(this));
            AddState(GameState.GUESS_HIGH, new GuessHighState(this));
            AddState(GameState.GUESS_LOW, new GuessLowState(this));
            AddState(GameState.GUESS_CORRECT, new GuessCorrectState(this));
        }

        public void SetState(GameState gameState)
        {
            _gameState = gameState;
            Refresh();
        }

        public void HandleInput(string input)
        {
            _states[_gameState].HandleInput(input);
        }

        public void Refresh()
        {
            _states[_gameState].Refresh();
        }
    }
}
