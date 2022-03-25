// ----------------------------------------------------------------------------
// MinMaxDouble.cs
// 
// Description: A double variant of the min/max value system.
// ----------------------------------------------------------------------------

using System;

namespace Adriana
{
    [Serializable]
    public class MinMaxDouble : MinMaxBase<double>
    {
        public override void IncreaseMinMax(double amount)
        {
            base.IncreaseMinMax(amount);

            min += amount;
            max += amount;
        }

        public override void ResetMinMax()
        {
            min = 0;
            max = 0;
        }
    }
}