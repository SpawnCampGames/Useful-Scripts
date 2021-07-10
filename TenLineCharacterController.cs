using UnityEngine; // SpawnCampGames
public class TenLineCharacterController : MonoBehaviour {
    public float speed = 50f, rotationSpeed = 50f;
    private Rigidbody rb;
    private void Start() =>  rb = GetComponent<Rigidbody>();
    void FixedUpdate() {
        transform.Rotate(0.0f, Input.GetAxis("Horizontal") * rotationSpeed, 0.0f);
        rb.velocity = transform.TransformDirection(new Vector3(0, 0, Input.GetAxisRaw("Vertical")) * speed);
    }
}