using ScaryTalesNewEngine.Defenitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScaryTalesNewEngine.Effects
{
    public sealed class EffectContext
    {
        public GameContext Context { get; }
        public PlayerId SourcePlayer { get; }
        public CardInstanceId SourceCard { get; }

        public EffectContext(
            GameContext context,
            PlayerId sourcePlayer,
            CardInstanceId sourceCard)
        {
            Context = context;
            SourcePlayer = sourcePlayer;
            SourceCard = sourceCard;
        }
    }

}
