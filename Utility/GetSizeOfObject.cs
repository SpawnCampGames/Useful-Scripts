using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetSizeOfObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(GetComponent<MeshFilter>().mesh.bounds.size.x);
        Debug.Log(GetComponent<MeshFilter>().mesh.bounds.size.y);
        Debug.Log(GetComponent<MeshFilter>().mesh.bounds.size.z);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
