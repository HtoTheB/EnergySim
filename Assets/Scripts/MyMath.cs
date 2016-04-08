using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts
{
    public static class MyMath
    {
        public static float degCos(float f) { return (Mathf.Cos(f * (Mathf.PI / 180))); }
        public static float degSin(float f) { return (Mathf.Sin(f * (Mathf.PI / 180))); }
    }
}
