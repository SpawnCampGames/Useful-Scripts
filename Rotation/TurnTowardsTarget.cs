//Script good for NPC's and other Vertical Objects
//Rotates GameObject on the Y axis to turn toward and lo at target.

using UnityEngine;

public class TurnTowardsTarget : MonoBehaviour
{
    public Transform target; 

    void Update()
    {
        //Get Difference between this position and targets position
        Vector3 difference = target.position - transform.position;
        
        //Use Atan2 then convert from Radians to Degrees
        float rotationY = Mathf.Atan2(difference.x, difference.z) * Mathf.Rad2Deg;
        
        //Rotate this only on the Y axis
        transform.rotation = Quaternion.Euler(0.0f, rotationY, 0.0f);
    }
}
