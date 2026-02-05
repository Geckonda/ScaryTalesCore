using ScaryTalesNewEngine.Abstractions;
using ScaryTalesNewEngine.Defenitions;
using ScaryTalesNewEngine.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScaryTalesNewEngine.States
{
    public sealed record GameState
    (
        GamePhase Phase,
        int TurnCount,
        PlayerId CurrentPlayerId,
        IReadOnlyList<PlayerId> PlayerOrder,
        bool IsGameOver
    );

}
