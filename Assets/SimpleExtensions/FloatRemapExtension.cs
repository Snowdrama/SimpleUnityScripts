using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class FloatRemapExtension
{
    /// <summary>
    /// Remaps a value from being within one range, to being within 
    /// a different range relative to it's position within the range
    /// 
    /// Useage:
    /// 3 is between 1 and 6
    /// var value = 3;
    /// var min = 1;
    /// var max = 6;
    /// var newMin = 3;
    /// var newMax = 10;
    /// var newValue = value.Remap(min, max, newMin, newMax); // 5.8
    /// </summary>
    /// <param name="value">the value to remap</param>
    /// <param name="fromMin">the original range min</param>
    /// <param name="fromMax">the original range max</param>
    /// <param name="toMin">the new range min</param>
    /// <param name="toMax">the new range max</param>
    /// <returns></returns>
    public static float Remap(this float value, float fromMin, float fromMax, float toMin, float toMax)
    {
        return (value - fromMin) / (fromMax - fromMin) * (toMax - toMin) + toMin;
    }

}
