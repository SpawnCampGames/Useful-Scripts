using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrategyCamera : MonoBehaviour
{
    public static StrategyCamera instance;

    public Transform camTransform;
    public GameObject player;

    public float normalSpeed;
    public float fastSpeed;

    public Vector3 newZoom;
    public Vector3 zoomAmount;

    private float movementSpeed;
    public float movementTime;

    public float rotationAmount;

    public Vector3 newPosition;
    public Quaternion newRotation;

    public Vector3 dragStartPosition;
    public Vector3 dragCurrentPosition;


    public Vector3 rotateStartPos;
    public Vector3 rotateCurrentPos;

    private Transform followTransform;
    private bool isPlayerToggled;
    
    void Awake()
    {
           Cursor.visible = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        newPosition = transform.position;
        newRotation = transform.rotation;
        newZoom = camTransform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            isPlayerToggled = !isPlayerToggled;

            if (isPlayerToggled)
            {
                followTransform = null;
            }
        }

        if (isPlayerToggled)
        {
            followTransform = player.transform;
        }

        if(followTransform != null)
        {
            transform.position = followTransform.position;
        }
        else
        {
            SpeedCheck();
            HandleMouseInput();
            HandleMovementInput();
        }
    }

    void SpeedCheck()
    {
        movementSpeed = normalSpeed;

        if (Input.GetKey(KeyCode.LeftShift))
        {
            movementSpeed = fastSpeed;
        }
    }

    void HandleMouseInput()
    {

        if (Input.GetMouseButtonDown(2))
        {
            rotateStartPos = Input.mousePosition;
        }

        if (Input.GetMouseButton(2))
        {
            rotateCurrentPos = Input.mousePosition;

            Vector3 difference = rotateStartPos - rotateCurrentPos;

            rotateStartPos = rotateCurrentPos;

            newRotation *= Quaternion.Euler(Vector3.up * (-difference.x / 5f));
        }

        if (Input.mouseScrollDelta.y != 0)
        {
            newZoom += Input.mouseScrollDelta.y * zoomAmount;
        }

        if (Input.GetMouseButtonDown(0)) {
            Plane plane = new Plane(Vector3.up, Vector3.zero);

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            float entry;

            if (plane.Raycast(ray, out entry)) {
                dragStartPosition = ray.GetPoint(entry);
            }
        }

        if (Input.GetMouseButton(0)) {
            Plane plane = new Plane(Vector3.up, Vector3.zero);

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            float entry;

            if (plane.Raycast(ray, out entry)) {
                dragCurrentPosition = ray.GetPoint(entry);

                newPosition = transform.position + dragStartPosition - dragCurrentPosition;
            }
        }
    }

    void HandleMovementInput()
    {        
        if (Input.GetKey(KeyCode.W))
        newPosition += (transform.forward * movementSpeed);

        if (Input.GetKey(KeyCode.S))
        newPosition += (transform.forward * -movementSpeed);

        if (Input.GetKey(KeyCode.A))
        newPosition += (transform.right * -movementSpeed);

        if (Input.GetKey(KeyCode.D))
        newPosition += (transform.right * movementSpeed);

        if (Input.GetKey(KeyCode.Q))
        newRotation *= Quaternion.Euler(Vector3.up * rotationAmount);

        if (Input.GetKey(KeyCode.E))
        newRotation *= Quaternion.Euler(Vector3.up * -rotationAmount);

        transform.position = Vector3.Lerp(transform.position, newPosition, Time.deltaTime * movementTime);
        transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, Time.deltaTime * movementTime);
        camTransform.localPosition = newZoom;
    }
}
