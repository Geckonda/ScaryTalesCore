using ScaryTalesNewEngine.Defenitions;
using ScaryTalesNewEngine.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScaryTalesNewEngine.States
{
    public sealed record CardState
    {
        public CardInstanceId InstanceId { get; init; }
        public CardDefinitionId DefinitionId { get; init; }
        public CardPosition Position { get; init; }
        public PlayerId? OwnerId { get; init; }
    }
}
