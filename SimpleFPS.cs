using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleFPS : MonoBehaviour
{
    public int avgFrameRate;

    public void Update()
    {
        int current = 0;
        current = (int)(1f / Time.unscaledDeltaTime);
        avgFrameRate = current;

        Debug.Log(avgFrameRate);
    }
}