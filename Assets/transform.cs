using UnityEngine;

public class CubeTransformations : MonoBehaviour
{
    public Vector3 translationAmount = new Vector3(2f, 0f, 0f);
    public Vector3 scalingFactor = new Vector3(2f, 1.5f, 0.5f);

    private void OnDrawGizmos()
    {
        
        Vector3 translatedPosition = transform.position + translationAmount;
        Vector3 scaledSize = new Vector3(
            transform.localScale.x * scalingFactor.x,
            transform.localScale.y * scalingFactor.y,
            transform.localScale.z * scalingFactor.z
        );

        
        Vector3[] corners = CalculateCorners(translatedPosition, scaledSize);

      
        Gizmos.color = Color.yellow;
        DrawCube(corners);
    }

  
    private Vector3[] CalculateCorners(Vector3 position, Vector3 size)
    {
        Vector3 halfSize = size / 2f;

        Vector3[] corners = new Vector3[]
        {
            position + new Vector3(-halfSize.x, -halfSize.y, -halfSize.z),
            position + new Vector3(halfSize.x, -halfSize.y, -halfSize.z),
            position + new Vector3(halfSize.x, -halfSize.y, halfSize.z),
            position + new Vector3(-halfSize.x, -halfSize.y, halfSize.z),
            position + new Vector3(-halfSize.x, halfSize.y, -halfSize.z),
            position + new Vector3(halfSize.x, halfSize.y, -halfSize.z),
            position + new Vector3(halfSize.x, halfSize.y, halfSize.z),
            position + new Vector3(-halfSize.x, halfSize.y, halfSize.z),
        };

        return corners;
    }

    
    private void DrawCube(Vector3[] corners)
    {
        for (int i = 0; i < corners.Length; i++)
        {
            Gizmos.DrawSphere(corners[i], 0.05f);
        }

        
        Gizmos.DrawLine(corners[0], corners[1]);
        Gizmos.DrawLine(corners[1], corners[2]);
        Gizmos.DrawLine(corners[2], corners[3]);
        Gizmos.DrawLine(corners[3], corners[0]);

        Gizmos.DrawLine(corners[4], corners[5]);
        Gizmos.DrawLine(corners[5], corners[6]);
        Gizmos.DrawLine(corners[6], corners[7]);
        Gizmos.DrawLine(corners[7], corners[4]);

        Gizmos.DrawLine(corners[0], corners[4]);
        Gizmos.DrawLine(corners[1], corners[5]);
        Gizmos.DrawLine(corners[2], corners[6]);
        Gizmos.DrawLine(corners[3], corners[7]);
    }
}