using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scipts
{
    public class MainMenuState : BaseState
    {
        public MainMenuState(StateMachine stateMachine):base(stateMachine)
        {

        }
        public override void HandleInput(string input)
        {
            switch(input)
            {
                case "1":
                    GameData.Reset();
                    SetState(GameState.MAKE_GUESS);
                    break;
                case "2":
                    SetState(GameState.INSTRUCTIONS);
                    break;
                case "3":
                    SetState(GameState.CONFIRM_QUIT);
                    break;
                default:
                    Terminal.Write("\nPlease enter a valid selection.\n", false);
                    Refresh();
                    break;
            }
        }

        public override void Refresh()
        {
            Terminal.Write("\nMain Menu:\n", false);
            Terminal.Write("1) Start a new game\n", false);
            Terminal.Write("2) Learn how to play\n", false);
            Terminal.Write("3) Stop playing\n", false);
            Terminal.Write("\n>", false);
        }
    }
}
