using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class LayerMaskContainsExtension
{
    /// <summary>
    /// Compares to see if a layer exists in a layermask;
    /// 
    /// Usage:
    /// 
    /// LayerMask someLayerMask;
    /// LayerMask aSingleLayerMask;
    /// 
    /// if(someLayerMask.LayerMaskContains(aSingleLayerMask))
    /// </summary>
    /// <param name="layerMask">A layer mask with multiple layers</param>
    /// <param name="layer">A layer mask with a single layer</param>
    /// <returns></returns>
    public static bool LayerMaskContains(this LayerMask layerMask, int layer)
    {
        return layerMask == (layerMask | (1 << layer));
    }
}
