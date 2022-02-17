using UnityEngine;

public class SmoothCamera : MonoBehaviour
{
    public float dampTime;
    public float heightOffset;
    private Vector3 velocity = Vector3.zero;
    public Transform target;
    private Camera cam;

    private void Start()
    {
        cam = GetComponent<Camera>();
    }

    void FixedUpdate()
    {
        if (target)
        {
            Vector3 point = cam.WorldToViewportPoint(target.position);
            Vector3 delta = target.position - cam.ViewportToWorldPoint(new Vector3(0.5f, 0.5f - heightOffset, point.z));
            Vector3 destination = transform.position + delta;
            transform.position = Vector3.SmoothDamp(transform.position, destination, ref velocity, dampTime);
        }

    }
}
