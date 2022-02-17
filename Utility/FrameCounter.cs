using UnityEngine;
using System;
using TMPro;

public class FrameCounter : MonoBehaviour
{
    TextMeshProUGUI frameRateText;
    private int frameRateInteger;

    // Start is called before the first frame update
    void Start()
    {
        frameRateText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        frameRateInteger = Convert.ToInt32(1.0f / Time.deltaTime);
        frameRateText.text = frameRateInteger.ToString();
    }
}
