using UnityEngine;
public class PowerMeter : MonoBehaviour
{
    [Range(0,1)] // clamp float from 0 to 1 to normalize it
    float meter;
    float step;

    [SerializeField]
    float min; the value 0 or an empty meter represents
    [SerializeField]
    float max; // the value that 1 / 100 / or a full meter represents
    [SerializeField]
    float speed; // the speed to oscillate  

    void Update()
    {
        step += Time.deltaTime * speed; // increase step, which in turn moves meter towards 1 and back to zero
        meter = Mathf.PingPong(step, 1); // to start meter with a visual offset add to the step variable here
    }


    // An example function
    // When function runs the value of meter is run through a lerp with our target min and max values
    [ContextMenu("Use Value Of Meter")]
    public void UseMetersValue()
    {
        Debug.Log(Mathf.Lerp(min, max, meter));
        
        // if our starting value is zero we can do basic math and use our meter's value as a percentage
        // Debug.Log(max * meter);
    }
}
