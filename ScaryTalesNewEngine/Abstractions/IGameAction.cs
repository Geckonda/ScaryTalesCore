using ScaryTalesNewEngine.Defenitions;
using ScaryTalesNewEngine.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScaryTalesNewEngine.Abstractions
{
    public interface IGameAction
    {
        GameState Reduce(GameState state, GameContext context);
    }

}
