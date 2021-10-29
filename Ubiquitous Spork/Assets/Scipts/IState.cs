using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scipts
{
    internal interface IState
    {
        void Refresh();
        void HandleInput(string input);
    }
}
