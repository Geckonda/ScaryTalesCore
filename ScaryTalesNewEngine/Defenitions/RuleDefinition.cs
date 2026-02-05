using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScaryTalesNewEngine.Defenitions
{
    public class RuleDefinition
    {
        public RuleId Id { get; set; }
    }

    public readonly record struct RuleId(int Value);

}
