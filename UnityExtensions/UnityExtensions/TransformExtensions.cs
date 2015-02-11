using UnityEngine;
using System.Linq;
using System.Collections.Generic;
using System;

namespace Levolution.Unity.Extensions
{
    public static class TransformExtensions
    {
        public static IEnumerable<Transform> GetChildren(this Transform t)
        {
            return t.Cast<Transform>();
        }

        public static IEnumerable<Transform> GetChildren(this Transform t, Func<Transform, bool> predicate)
        {
            return t.GetChildren().Where(predicate);
        }
    }
}
