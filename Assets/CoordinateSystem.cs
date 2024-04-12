using UnityEngine;

public class CoordinateSystem : MonoBehaviour
{
    public Vector3 origin = Vector3.zero;

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(origin, origin + Vector3.right);

        Gizmos.color = Color.green;
        Gizmos.DrawLine(origin, origin + Vector3.up);

        Gizmos.color = Color.blue;
        Gizmos.DrawLine(origin, origin + Vector3.forward);
    }
}