using UnityEngine;

public class SimpleRaycast2D : MonoBehaviour
{
    public float lengthOfRay; // how long we want the ray
    private Vector2 positionOfRay; // the position of the start point of ray
    private Vector2 directionOfRay; // direction of the ray

    private Ray2D rayToDrawToScreen;

    private void Start()
    {
        positionOfRay = transform.position; // in start we set the position to our position
        directionOfRay = transform.right;   // i default the direction to transform.right which is (0,1)
                                            //we'll multiply that by the length of the ray
                                            // we could also set this to -transform.right to point behind us
                                            // and transform.up to look up or -up for down
    }

    private void Update()
    {
        positionOfRay = transform.position; // we constantly set our position so when we move the player the ray follows
        directionOfRay = transform.right; // same here

        Ray2D ray = new(positionOfRay, directionOfRay); // every frame we create a new ray and pass in our positions
        rayToDrawToScreen = ray; // we set the ray To draw here to the ray we just made

        if (Input.GetMouseButtonDown(0)) // if we press the mouse button
        {
            Debug.Log("clicked");
            Debug.Log(ray.origin);
            Debug.Log(ray.direction);

            RaycastHit2D hit = Physics2D.Raycast(positionOfRay, directionOfRay, lengthOfRay); //we assign our hit to be our raycast

            if(hit && hit.transform.CompareTag("Enemy")) // we check if there was a hit
            {
                Debug.Log("Hit the Enemy"); // then with the Compare Tag only things tagged as "Enemy" triggers this debug
            }
        }
    }

    private void OnDrawGizmos() // all the pretty editor stuff so we can see what we're doing
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawLine(rayToDrawToScreen.origin, rayToDrawToScreen.origin + rayToDrawToScreen.direction * lengthOfRay);
    }
}
