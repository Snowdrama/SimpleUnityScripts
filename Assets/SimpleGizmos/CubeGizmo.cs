using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeGizmo : MonoBehaviour
{
    public Vector3 size = new Vector3(1, 1, 1);
    public bool onSelected = true;
    public bool wireCube = true;
    public Color color = Color.white;
    private void OnDrawGizmos()
    {
        Gizmos.color = color;
        if (!onSelected)
        {
            if (wireCube)
            {
                Gizmos.DrawWireCube(this.transform.position, size);
            }
            else
            {
                Gizmos.DrawCube(this.transform.position, size);
            }
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = color;
        if (onSelected)
        {
            if (wireCube)
            {
                Gizmos.DrawWireCube(this.transform.position, size);
            }
            else
            {
                Gizmos.DrawCube(this.transform.position, size);
            }
        }
    }
}
