using UnityEngine; // SpawnCampGames
public class TenLineCharacterController : MonoBehaviour {
    public float speed = 10f, rotationSpeed = 10f;  // declare our variables
    private Rigidbody rb; // declare our rigidbody to control
    private void Start() =>  rb = GetComponent<Rigidbody>(); // assign the rigidbody
    void FixedUpdate() {
        rb.MoveRotation(rb.rotation * Quaternion.Euler(0.0f,Input.GetAxis("Horizontal") * rotationSpeed,0.0f)); // rotate our rigidbody
        rb.velocity = transform.TransformDirection(new Vector3(0, 0, Input.GetAxisRaw("Vertical")) * speed); // move our rigidbody by setting its velocity
    }
}