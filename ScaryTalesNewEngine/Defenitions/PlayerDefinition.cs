using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScaryTalesNewEngine.Defenitions
{
    public class PlayerDefinition
    {
        public PlayerId Id {  get; set; }
        public string Name { get; private set; }
    }
    public readonly record struct PlayerId(int Value);
}
