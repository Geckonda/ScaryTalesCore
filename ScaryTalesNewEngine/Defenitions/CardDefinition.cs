using ScaryTalesNewEngine.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScaryTalesNewEngine.Defenitions
{
    public class CardDefinition
    {
        public CardId Id { get; }
        public string Name { get; }
        public CardType Type { get; }
        public int Points { get; }
        public string EffectDescription { get; }
        public CardPosition DefaultPosition { get; }
        public int CardCountInDeck { get; }

        public ICardEffect Effect { get; }
        public override string ToString()
        {
            return $"{this.Id} | {this.Name}";
        }
    }
    public readonly record struct CardId(int Value);
}
