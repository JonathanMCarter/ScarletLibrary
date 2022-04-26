using System.Collections.Generic;
using UnityEngine;

namespace Adriana
{
    public class ObjectPool<T>
    {
        private readonly List<T> memberObjects;
        private readonly HashSet<T> unavailableObjects;
        private readonly GameObject prefab;
        private readonly Transform parent;
        
        
        public ObjectPool(GameObject prefab, Transform parent, int initialCount)
        {
            this.prefab = prefab;
            this.parent = parent;

            memberObjects = new List<T>();
            unavailableObjects = new HashSet<T>();

            for (var i = 0; i < initialCount; i++)
                memberObjects.Add(Object.Instantiate(prefab, parent).GetComponentInChildren<T>(true));
        }


        private T Create()
        {
            var newMember = Object.Instantiate(prefab, parent).GetComponentInChildren<T>(true);
            memberObjects.Add(newMember);
            return newMember;
        }
        

        public T Assign()
        {
            foreach (var t in memberObjects)
            {
                if (unavailableObjects.Contains(t)) continue;
                unavailableObjects.Add(t);
                return t;
            }

            var newMember = Create();
            unavailableObjects.Add(newMember);
            return newMember;
        }


        public void Return(T member)
        {
            unavailableObjects.Remove(member);
        }
    }
}