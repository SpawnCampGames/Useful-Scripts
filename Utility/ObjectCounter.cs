using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCounter : MonoBehaviour
{
    private Object[] gameObjects;
    private Object[] monoBehaviours;
    private Object[] audioSources;

    // Start is called before the first frame update
    void Start()
    {
        gameObjects = FindObjectsOfType(typeof(Transform));
        Debug.Log("Number of GameObjects: " + gameObjects.Length);

        monoBehaviours = FindObjectsOfType(typeof(MonoBehaviour));
        Debug.Log("Number of MonoBehaviors: " + monoBehaviours.Length);

        audioSources = FindObjectsOfType(typeof(AudioSource));
        Debug.Log("Number of AudioSources: " + audioSources.Length);
    }
}
