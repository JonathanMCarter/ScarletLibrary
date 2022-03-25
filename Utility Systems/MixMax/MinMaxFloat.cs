// ----------------------------------------------------------------------------
// MinMaxFloat.cs
// 
// Description: A float variant of the min/max value system.
// ----------------------------------------------------------------------------

using System;

namespace Adriana
{
    [Serializable]
    public class MinMaxFloat : MinMaxBase<float>
    {
        public override void IncreaseMinMax(float amount)
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