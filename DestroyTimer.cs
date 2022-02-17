//Destroy GameObject after [time] seconds

using UnityEngine;

public class DestroyTimer : MonoBehaviour
{
    [Range(0,float.PositiveInfinity)]
    public float time;

    void Start()
    {
        Destroy(this.gameObject, time);
    }
}
