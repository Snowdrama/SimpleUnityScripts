using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class InstantiateExtension
{
    /// <summary>
    /// Instantiate a prefab with a position of Vector3.zero and a rotation of Quaternion.identity
    /// </summary>
    /// <param name="prefab">the prefab to instantiate</param>
    /// <returns>the instantiated game object</returns>
    public static GameObject Instantiate(GameObject prefab)
    {
        return UnityEngine.GameObject.Instantiate(prefab, Vector3.zero, Quaternion.identity);
    }

    /// <summary>
    /// Instantiate a prefab at a position and a rotation of Quaternion.identity
    /// </summary>
    /// <param name="prefab">the prefab to instantiate</param>
    /// <param name="position">The position to instantiate at</param>
    /// <returns>the instantiated game object</returns>
    public static GameObject Instantiate(GameObject prefab, Vector3 position)
    {
        return UnityEngine.GameObject.Instantiate(prefab, position, Quaternion.identity);
    }
}
