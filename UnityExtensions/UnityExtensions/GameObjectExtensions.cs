using UnityEngine;
using System.Linq;
using System.Collections.Generic;
using System;

namespace Levolution.Unity.Extensions
{
    public static class GameObjectExtensions
    {
        public static IEnumerable<GameObject> GetChildren(this GameObject gameObject)
        {
            if (gameObject == null) { return Enumerable.Empty<GameObject>(); }
            return gameObject.transform.GetChildren().Select(x => x.gameObject);
        }

        public static IEnumerable<GameObject> GetChildren(this GameObject gameObject, Func<GameObject, bool> predicate)
        {
            if (gameObject == null) { return Enumerable.Empty<GameObject>(); }
            return gameObject.GetChildren().Where(predicate);
        }

        public static void DestroyChildren(this GameObject gameObject)
        {
            if (gameObject == null) { return; }

            foreach (var c in gameObject.GetChildren())
            {
                if (c != null)
                {
                    UnityEngine.Object.Destroy(c);
                }
            }
        }
    }
}
