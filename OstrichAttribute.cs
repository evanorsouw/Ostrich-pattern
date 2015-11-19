using System;

namespace Evo.Pattens.Ostrich
{
    /// <summary>
    /// Annotation to be placed above methods or classes where the Ostrich pattern
    /// has is applied.
    /// The Ostrich patten is applied to situations where coding shortcuts are taken
    /// that disregard corner cases or exceptional situations that 'should not' or
    /// are 'unlikely to' happen. These shortcuts are taken by developers due to
    /// unclear requirements, lack of time, laziness or incompetence.
    /// </summary>
    public class OstrichAttribute : Attribute
    {
        public string EvasiveReason { get; private set; }

        /// <param name="evasiveReason">A brief description of the conditions that have been disregarded.</param>
        public OstrichAttribute(string evasiveReason)
        {
            EvasiveReason = evasiveReason;
        }
    }
}