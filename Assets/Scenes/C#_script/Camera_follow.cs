
using UnityEngine;

public class Camera_follow : MonoBehaviour
{
    public Transform target;

    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    void LateUpdate()
    {
        Vector3 desirePosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desirePosition, smoothSpeed);
        transform.position = smoothedPosition;
    }
}
