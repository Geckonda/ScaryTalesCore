using ScaryTalesNewEngine.Defenitions;
using ScaryTalesNewEngine.States;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScaryTalesNewEngine
{
    public sealed record GameContext
        (
            GameState GameState,                  // Основной GameState
            BoardState BoardState,                // Состояние доски
            DeckState DeckState,                  // Состояние колоды
            IReadOnlyDictionary<CardInstanceId, CardState> CardStates, // Состояние всех карт
            IReadOnlyDictionary<PlayerId, PlayerState> PlayerStates, // Состояние всех игроков
            IReadOnlyDictionary<CardDefinitionId, CardDefinition> CardDefinitions, // Определения карт
            IReadOnlyDictionary<ItemId, ItemDefinition> ItemDefinitions, // Определения предметов
            IReadOnlyDictionary<RuleId, RuleDefinition> RuleDefinitions // Определения правил
        );

}
