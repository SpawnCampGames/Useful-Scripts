public class Move : MonoBehaviour
{
    public Vector3 dir;
    public float speed;
    public bool matchForwardDir;

    private void Start()
    {
        if (matchForwardDir)
        {
            dir = transform.forward;
        }
    }

    private void Update()
    {
        transform.Translate(dir * speed * Time.deltaTime);
    }
}
