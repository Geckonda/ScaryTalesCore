using ScaryTalesNewEngine.Defenitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScaryTalesNewEngine.States
{
    public sealed class DeckState
    {
        public IReadOnlyList<CardId> Cards { get; init; }

        public int Count => Cards.Count;
    }

}
