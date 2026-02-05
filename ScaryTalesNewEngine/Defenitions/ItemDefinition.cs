using ScaryTalesNewEngine.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScaryTalesNewEngine.Defenitions
{
    public class ItemDefinition
    {
        public ItemId Id { get; set; }
        public string Name { get; }
        public ItemType Type { get; }
        /// <summary>
        /// Количество предметов по умолчанию
        /// </summary>
        public int DefaultAmount { get; }
    }

    public readonly record struct ItemId(int Value);
}
