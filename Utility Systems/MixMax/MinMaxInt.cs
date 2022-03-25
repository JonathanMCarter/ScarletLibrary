// ----------------------------------------------------------------------------
// MinMaxInt.cs
// 
// Description: A int variant of the min/max value system.
// ----------------------------------------------------------------------------

using System;

namespace Adriana
{
    [Serializable]
    public class MinMaxInt : MinMaxBase<int>
    {
        public override void IncreaseMinMax(int amount)
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