using System.Collections.Generic;

namespace NRules.RuleModel
{
    /// <summary>
    /// Grouping element based on the logical OR condition.
    /// </summary>
    public class OrElement : GroupElement
    {
        internal OrElement(IEnumerable<Declaration> declarations, IEnumerable<RuleLeftElement> childElements)
            : base(declarations, childElements)
        {
        }

        internal override void Accept<TContext>(TContext context, RuleElementVisitor<TContext> visitor)
        {
            visitor.VisitOr(context, this);
        }
    }
}