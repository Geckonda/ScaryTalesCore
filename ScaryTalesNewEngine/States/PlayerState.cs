using ScaryTalesNewEngine.Defenitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScaryTalesNewEngine.States
{
    public sealed class PlayerState
    {
        public PlayerId Id { get; init; }
        public int Score { get; init; }

        public IReadOnlyList<CardId> Hand { get; init; }
        public IReadOnlyList<ItemId> Items { get; init; }
    }

}
