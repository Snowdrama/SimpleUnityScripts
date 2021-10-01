using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereGizmo : MonoBehaviour
{
    public float range = 1;
    public bool onSelected = true;
    public bool wireSphere = true;
    public Color color = Color.white;
    private void OnDrawGizmos()
    {
        Gizmos.color = color;
        if (!onSelected)
        {
            if(wireSphere)
            {
                Gizmos.DrawWireSphere(this.transform.position, range);
            }
            else
            {
                Gizmos.DrawSphere(this.transform.position, range);
            }
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = color;
        if (onSelected)
        {
            if (wireSphere)
            {
                Gizmos.DrawWireSphere(this.transform.position, range);
            }
            else
            {
                Gizmos.DrawSphere(this.transform.position, range);
            }
        }
    }
}
