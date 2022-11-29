using UnityEngine;

public class MouseParallax : MonoBehaviour {

    private Vector3 mousePos; 
    private Vector3 startPos;

    public float parallaxModifier;

    void Start() {
        startPos = transform.position;
    }

    void Update() {

        // get mouse position and set Z to match gameobject's Z
        mousePos = Camera.main.ScreenToViewportPoint(Input.mousePosition);
        mousePos.z = transform.position.z;

        // offset to remap mousePosition
        // making center of screen (0,0)
        mousePos.x -= .5f;
        mousePos.y -= .5f;

        // clamp mouse position so parallax only happens while mouse is on screen
        mousePos.x = Mathf.Clamp(mousePos.x, -.5f, .5f);
        mousePos.y = Mathf.Clamp(mousePos.y, -.5f, .5f);

        // flip mousePos so gameobject parallaxes opposite
        mousePos.x = -mousePos.x;
        mousePos.y = -mousePos.y;

        // set gameobject position with a modifier (speed & distance of effect)
        transform.position = new Vector3(startPos.x + (mousePos.x * parallaxModifier), startPos.y + (mousePos.y * parallaxModifier), mousePos.z);
    }
}

//SpawnCampGames
