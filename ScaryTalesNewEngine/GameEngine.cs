using ScaryTalesNewEngine.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScaryTalesNewEngine
{
    public sealed class GameEngine
    {
        // Текущий контекст игры
        public GameContext Context { get; private set; }

        // Конструктор с начальным состоянием
        public GameEngine(GameContext initialContext)
        {
            Context = initialContext;
        }

        /// <summary>
        /// Применяет один action к игре и обновляет контекст
        /// </summary>
        public void ApplyAction(IGameAction action)
        {
            // Reduce возвращает новый GameState, но нам нужен новый GameContext
            var newGameState = action.Reduce(Context.GameState, Context);

            // Создаём новый GameContext с обновлённым GameState
            // Остальные state остаются теми же, пока action их явно не меняет через context
            Context = Context with { GameState = newGameState };
        }

        /// <summary>
        /// Применяет цепочку действий
        /// </summary>
        public void ApplyActions(IEnumerable<IGameAction> actions)
        {
            foreach (var action in actions)
            {
                ApplyAction(action);
            }
        }
    }

}
