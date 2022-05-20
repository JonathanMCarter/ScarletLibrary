// ----------------------------------------------------------------------------
// ArrayExtension.cs
// 
// Author: Jonathan Carter (A.K.A. J)
// Date: 15/02/2022
// ----------------------------------------------------------------------------

using System;

namespace Erissa.Extensions
{
    public static class ArrayExtension
    {
        /// <summary>
        /// Checks to see if the array is empty or null.
        /// </summary>
        /// <param name="array">The array to compare.</param>
        /// <returns>Bool</returns>
        public static bool IsEmptyOrNull(this Array array)
        {
            if (array == null) return true;
            if (array.Length <= 0) return true;
            return false;
        }
    }
}