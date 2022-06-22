// ----------------------------------------------------------------------------
// ArrayExtension.cs
// 
// Description: An extension class for any array.
// ----------------------------------------------------------------------------

using System;
using UnityEngine;

namespace Erissa.Extensions
{
    /// <summary>
    /// An extension class for any array.
    /// </summary>
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


        /// <summary>
        /// Adds a new member to the array...
        /// </summary>
        /// <param name="array">The array to add to</param>
        /// <param name="newMember">The new member to add</param>
        /// <typeparam name="T">The type of the array & member</typeparam>
        /// <returns>The adjusted array.</returns>
        public static T[] Add<T>(this T[] array, T newMember)
        {
            var newArray = new T[array.Length + 1];

            for (var i = 0; i < newArray.Length; i++)
            {
                if (i <= newArray.Length - 1)
                    newArray[i] = array[i];
                else
                    newArray[i] = newMember;
            }

            return newArray;
        }
        
        
        /// <summary>
        /// Removes a new member from the array...
        /// </summary>
        /// <param name="array">The array to remove from</param>
        /// <param name="member">The member to remove</param>
        /// <typeparam name="T">The type of the array & member</typeparam>
        /// <returns>The adjusted array.</returns>
        public static T[] Remove<T>(this T[] array, T member)
        {
            var newArray = new T[array.Length - 1];

            for (var i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(member)) continue;
                newArray[i] = array[i];
            }

            return newArray;
        }


        /// <summary>
        /// Runs an action on every element of the array.
        /// </summary>
        /// <param name="array">The array to affect.</param>
        /// <param name="callback">The callback to run on each member</param>
        /// <typeparam name="T">The type of the array</typeparam>
        public static void ForEachComponent<T>(this T[] array, Action<T> callback) where T : Component
        {
            foreach (var member in array)
                callback.Invoke(member);
        }
    }
}